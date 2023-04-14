using Newtonsoft.Json;
using PBLLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Workflows
{
    public static class AppSettings
    {
        public static void ApplyUserSettings(int UserID)
        {
            string fileFullPath = GlobalConfig.Instance.PathFileAppSettings() + "UserSettings.json";
            string json = File.ReadAllText(fileFullPath);
            JsonConvert.DeserializeObject<List<UserSetting>>(json).ForEach(item =>
            {
                if (item.UserId == UserID)
                {
                    SoundConfig.ChangeVolumn(item.Volume * 10);
                    SoundConfig.ChangeVoice(item.Voice == false ? SoundConfig.Voice.Male : SoundConfig.Voice.Female);
                }
            });
        }

        public static UserSetting getUserSettings(int UserID)
        {
            string fileFullPath = GlobalConfig.Instance.PathFileAppSettings() + "UserSettings.json";
            string json = File.ReadAllText(fileFullPath);
            return JsonConvert.DeserializeObject<List<UserSetting>>(json).FirstOrDefault(p => p.UserId == UserID);
        }

        public static void setUserSettings(int UserID, int Volume, bool Voice)
        {
            List<UserSetting> userSettings = new List<UserSetting>();
            string fileFullPath = GlobalConfig.Instance.PathFileAppSettings() + "UserSettings.json"; 
            try
            {
                string json = File.ReadAllText(fileFullPath);
                userSettings = JsonConvert.DeserializeObject<List<UserSetting>>(json);
            }
            catch
            {
                
            }
            finally
            {
                bool check = false;
                for (int i = 0; i < userSettings.Count; i++)
                {
                    if (userSettings[i].UserId == UserID)
                    {
                        userSettings[i].Volume = Volume;
                        userSettings[i].Voice = Voice;
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    userSettings.Add(new UserSetting()
                    {
                        UserId = UserID,
                        Volume = Volume,
                        Voice = Voice,
                    });
                }

                string output = JsonConvert.SerializeObject(userSettings, Formatting.Indented);
                File.WriteAllText(fileFullPath, output);
            }
            
        }


    }

    public class UserSetting 
    {
        public int UserId { set; get; }
        public int Volume { set; get; }
        public bool Voice { set; get; } // false: Male; true: Female
    }
}

