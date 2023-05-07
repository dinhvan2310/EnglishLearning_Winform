using BLL.Workflows;
using PBL3.Utilities;
using PBLLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormMiniGame : Form
    {
        public FormMiniGame()
        {
            InitializeComponent();
        }

        #region EVENTS

        private async void GameOn_Click(object sender, EventArgs e)
        {
            int index = ((Button)sender).TabIndex;
            if (!LoginWorkflow.Instance.IsPremium() && index == 2)
            {
                FormMessageBox form = new FormMessageBox("Không có quyền hạn",
                    "Bạn không có phép để chơi trò chơi này\nVui lòng mua gói người dùng", FormMessageBox.MessageType.Info);

                form.ShowDialog();
                return;
            }

            FormLoading formLoading = new FormLoading();
            formLoading.TopLevel = false;
            formLoading.Dock = DockStyle.Bottom;
            panelBase.Controls.Add(formLoading);
            formLoading.BringToFront();
            formLoading.Show();

            if (index == 1)
                GlobalForm.MainForm.SwitchForm(await Task.Run(() => new FormGame1()), FormType.Weak);
            else if (index == 2)
                GlobalForm.MainForm.SwitchForm(await Task.Run(() => new FormGame2()), FormType.Weak);

            formLoading.Close();

        }

        #endregion
    }
}
