using EFramework;
using EFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Components
{
    public class PackageManager
    {
        public UserPacket GetPacket_ByName(string packetName)
        {
            using (DictionaryContext dbContext = new DictionaryContext())
            {
                UserPacket result = new UserPacket();


                result = dbContext.UserPacket
                        .Single(p => p.Name == packetName);

                return result;
            }
        }

        public bool SetPricePacket(string packetName, int price)
        {
            using (DictionaryContext dbContext = new DictionaryContext())
            {
                    UserPacket result = new UserPacket();
                    result = dbContext.UserPacket
                            .Single(p => p.Name == packetName);
                    result.Price = price;
                    dbContext.SaveChanges();
                    return true;
            }
        }

        public UserPacketInfo GetUserPacketInfo(int userID, string namePacket)
        {
            using (var dbContext = new DictionaryContext())
            {
                int packetID = dbContext.UserPacket.SingleOrDefault(p => p.Name == namePacket).PacketID;
                return dbContext.UserPacketInfo.SingleOrDefault(p => p.AccountID == userID && p.PacketID == packetID);
            }
        }

        public bool IsHasUserPacket(int userID, string namePacket)
        {
            return (GetUserPacketInfo(userID, namePacket) != null) ? true : false;
        }

        public bool CheckUserPackageDuration(int userID, string namePacket)
        {
            using (var dbContext = new DictionaryContext())
            {
                UserPacket userPacket = dbContext.UserPacket.SingleOrDefault(p => p.Name == namePacket);
                int packetID = userPacket.PacketID;
                UserPacketInfo userPacketInfo = dbContext.UserPacketInfo.SingleOrDefault(p => p.PacketID == packetID && p.AccountID == userID);
                if (userPacketInfo != null)
                {
                    if (userPacketInfo.DueDate < DateTime.Now)
                    {
                        CancelUserPacket(userID, namePacket);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }

            }
        }

        private bool CancelUserPacket(int userID, string namePacket)
        {
            using (var dbContext = new DictionaryContext())
            {
                UserPacket userPacket = dbContext.UserPacket.SingleOrDefault(p => p.Name == namePacket);
                int packetID = userPacket.PacketID;
                UserPacketInfo userPacketInfo = dbContext.UserPacketInfo.SingleOrDefault(p => p.PacketID == packetID && p.AccountID == userID);
                if (userPacketInfo != null)
                {
                    dbContext.UserPacketInfo.Remove(userPacketInfo);
                    dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool BuyUserPacket(int userID, string namePacket)
        {
            using (var dbContext = new DictionaryContext())
            {
                AccountManager am = new AccountManager();
                int balance = am.GetAccountDetail(userID).Balance;
                UserPacket userPacket = dbContext.UserPacket.SingleOrDefault(p => p.Name == namePacket);
                int pricePacket = userPacket.Price;
                int packetID = userPacket.PacketID;
                if (balance >= pricePacket)
                {
                    var detailedInformation = dbContext.DetailedInformation.Find(userID);
                    detailedInformation.Balance = balance - pricePacket;
                    /*dbContext.SaveChanges();*/
                    UserPacketInfo userPacketInfo = new UserPacketInfo()
                    {
                        AccountID = userID,
                        PacketID = packetID,
                        DueDate = DateTime.Now.AddDays(userPacket.TimeOfUse),
                    };
                    dbContext.UserPacketInfo.Add(userPacketInfo);
                    dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public List<UserPacketInfo> GetUserPacketInfo_All_ByNamePacket(string namePacket)
        {
            using (var dbContext = new DictionaryContext())
            {
                int packetID = dbContext.UserPacket.SingleOrDefault(p => p.Name == namePacket).PacketID;
                return dbContext.UserPacketInfo.Where(p => p.PacketID == packetID).ToList();
            }
        }
    }
}
