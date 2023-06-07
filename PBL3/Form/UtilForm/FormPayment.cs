using ManageMiniMart.BLL;
using ManageMiniMart.Custom;
using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Windows.Forms;

namespace ManageMiniMart.View
{
    public delegate void ProductDelegate(int productId,int amount);
    public delegate void CustomerDelegate(string customerId);
    public partial class FormPayment : Form
    {
        private ProductService productService;
        private DiscountService discountService;
        private CustomerService customerService;
        private BillService billService;
        private Bill_ProductService bill_ProductService;
        private List<ProductInBill> listProductInBill;

        private Account currentAccount;

        public FormPayment(Account account = null)
        {
            InitializeComponent();

            productService = new ProductService();
            discountService = new DiscountService();
            customerService = new CustomerService();
            billService = new BillService();
            bill_ProductService = new Bill_ProductService();
            listProductInBill = new List<ProductInBill>();

            this.currentAccount = account;
            cbbPayment.DataSource = getCBBMethodPay();
        }
        public List<string> getCBBMethodPay()
        {
            List<string> strings = new List<string>();
            strings.Add("Cash");
            strings.Add("Bank account");
            return strings;
        }
        public void loadProductInBill()
        {
            dgvProduct.DataSource = null;
            dgvProduct.DataSource = this.listProductInBill;
            dgvProduct.Refresh();
        }
        private bool checkProduct_ExistIn_listProductInBill(int productId)                // kiểm tra xem đã add trước đó chưa
        {
            bool check = false;
            foreach (var product in listProductInBill)
            {
                if (product.ProductId == productId)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void updateProduct(ProductInBill product)
        {
            for(int i = 0; i < listProductInBill.Count; i++)
            {
                if (listProductInBill[i].ProductId == product.ProductId)
                {
                    listProductInBill[i] = product;
                }
            }
        }
        private ProductInBill getProductInBillById(int productId)
        {
            foreach( var product in listProductInBill)
            {
                if(product.ProductId == productId)
                {
                    return product;
                }
            }
            return null;
        }

        private void setCustomerId_Input(string customerId)
        {
            txtCustomerName.Text = customerService.getCustomerById(customerId).customer_name;
            txtCustomerID.Text = customerId;
            if (customerService.getCustomerPoint(customerId) != 0)
            {
                checkUsePoint.Visible = true;
                guna2HtmlLabel1.Visible = true;
                showPoint.Text = customerService.getCustomerPoint(customerId).ToString() + " points";
            }
            else
            {
                checkUsePoint.Visible = false;
                guna2HtmlLabel1.Visible = false;
                showPoint.Text = "";
            }
        }
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            SelectCustomerForm selectCustomerForm = new SelectCustomerForm(setCustomerId_Input);
            selectCustomerForm.setCustomer(customerName);
            selectCustomerForm.Show();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string productName = txtProductId.Text;
            SelectProductForm selectProductForm = new SelectProductForm(AddProductInBill);
            selectProductForm.loadAllProducts(productName);
            selectProductForm.ShowDialog();
        }
        private void AddProductInBill(int productId,int amount)
        {
            Product product = productService.getProductById(productId);
            string sale = "";
            int discountId = 0;
            foreach (var discount in product.Product_Discount)
            {
                sale += discount.Discount.discount_name;
                discountId = discount.Discount.discount_id;
            }
            if(amount > product.quantity)
            {
                throw new Exception("Amount product in stock not enough for buy !");
            }
            else
            {
                if (checkProduct_ExistIn_listProductInBill(productId))      // Nếu đã add trước đó rồi
                {
                    ProductInBill productInBill = getProductInBillById(productId);
                    int amountCurrent = productInBill.Amount;
                    if ((amountCurrent+amount) > product.quantity)
                    {
                        //MyMessageBox myMessage = new MyMessageBox();
                        //myMessage.show("Amount product in stock not enough for buy!", "Nofitication");
                        //return;
                        throw new Exception("Amount product in stock not enough for buy !");
                    }
                    else
                    {
                        productInBill.Amount += amount;
                        updateProduct(productInBill);
                    }
                    
                }
                else
                {
                    listProductInBill.Add(new ProductInBill
                    {
                        ProductId = productId,
                        Name = product.product_name,
                        Brand = product.brand,
                        Price = product.price,
                        Quantity = product.quantity,
                        Amount = amount,
                        Category_name = product.Category.category_name,
                        Sale = sale,
                        DiscountId = discountId
                    });
                }
            }
            
            loadProductInBill();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (listProductInBill.Count == 0) throw new Exception("Chua co san pham trong gio hang");
            MyMessageBox myMessage = new MyMessageBox();
            DialogResult rs = myMessage.show("Are you complete ?", "Confirm", MyMessageBox.TypeMessage.YESNO, MyMessageBox.TypeIcon.INFO);
            if(rs == DialogResult.Yes)
            {
                string customerId = txtCustomerID.Text;
                Customer customer = customerService.getCustomerById(customerId);
                if(customer == null)
                {
                    customerId = null;
                }
                string employeeId = currentAccount.person_id;
                string methodPayment = cbbPayment.Text;
                DateTime currentTime = DateTime.Now;
                double totalMoney = 0;
                Bill bill = new Bill
                {
                    person_id= employeeId,
                    customer_id= customerId,
                    created_time = currentTime,
                    payment_method = methodPayment,
                    
                };
                billService.saveBill(bill);
                int idBill = billService.IdBillAdded;
                foreach(var product in listProductInBill)
                {
                    Product product1 = productService.getProductById(product.ProductId);
                    Discount discount = discountService.getDiscountById(product.DiscountId);
                    int percentOff =  0;
                    if(discount != null)
                    {
                        percentOff = (int)discount.sale;
                    }
                    totalMoney += (product.Price * (100-percentOff)/100)*product.Amount;

                    Bill_Product bill_Product = new Bill_Product
                    {
                        bill_id = idBill,
                        product_id = product.ProductId,
                        quantity = product.Amount,
                        price = product.Price * (100 - percentOff) / 100 // Lưu giá ở đây là giá sau khi đã áp dụng giảm giá
                    };
                    // sau khi thêm sản phẩm vào bill thì giảm số lượng hàng hóa có trong kho
                    product1.quantity = product1.quantity - product.Amount;
                    productService.saveProduct(product1);
                    bill_ProductService.saveBill_Product(bill_Product);
                    
                }
                if(customer != null)
                {                                                       // 20000 = 1 đ
                    int oldPoint = (int)customer.point;                  // 1đ = 1000
                    int pointAdd = (int)(totalMoney / 20000);
                    if (checkUsePoint.Checked)
                    {
                        if (totalMoney < Convert.ToDouble(customer.point * 1000))
                        {
                            customer.point = (customer.point * 1000 - (int)totalMoney)/1000;
                            totalMoney = 0;
                            bill.used_points = oldPoint - customer.point;
                        }
                        else
                        {
                            totalMoney -= Convert.ToDouble(customer.point * 1000);
                            customer.point = 0;
                            bill.used_points = oldPoint;
                        }
                    }
                    customer.point += pointAdd;
                    billService.saveBill(bill);
                    customerService.saveCustomer(customer);
                    checkUsePoint.Checked = false;
                    showPoint.Text = customerService.getCustomerPoint(customerId).ToString() + " points";
                }

                //MyMessageBox myMessage1 = new MyMessageBox();
                //myMessage1.show("Total money = " + totalMoney);
                Details_Bill_Print details_Bill = new Details_Bill_Print();
                details_Bill.setDatagridView(idBill);
                details_Bill.ShowDialog();
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProduct.SelectedRows)
                {
                    listProductInBill.RemoveAt(row.Index);
                }
                loadProductInBill();
            }
        }
    }
}
