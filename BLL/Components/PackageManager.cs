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
                try
                {
                    UserPacket result = new UserPacket();
                    result = dbContext.UserPacket
                            .Single(p => p.Name == packetName);
                    result.Price = price;
                    dbContext.SaveChanges();
                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
