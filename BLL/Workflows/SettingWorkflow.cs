using BLL.Components;
using PBLLibrary;
using Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Workflows
{
    public class SettingWorkflow
    {
        public static SettingWorkflow Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new SettingWorkflow();


                return _Instance;
            }

            private set { }
        }
        private static SettingWorkflow _Instance;

        private SoundManager _SoundManager;

        private SettingWorkflow()
        {
            _SoundManager = new SoundManager();
        }


        public void Speak(string sentence)
        {
            _SoundManager.Speak(sentence);
        }


        public void ChangeVolumn(int volumn)
        {
            _SoundManager.ChangeVolumn(volumn);
        }

        public void ChangeVoice(Voice voice)
        {
            _SoundManager.ChangeVoice(voice);
        }

        public bool IsSpeaking()
        {
            return _SoundManager.IsSpeaking;
        }

        private void CreateStandardUserSettingsJson(int UserID)
        {
            string fileFullPath = GlobalConfig.Instance.PathFileJS() + "UserSettings.json";
            UserSetting userSetting = new UserSetting()
            {
                UserId = UserID,
                Volume = 10,
                Voice = false,
                Goal = 45,
            };
            List<UserSetting> userSettings = new List<UserSetting>();
            userSettings.Add(userSetting);
            string output = JsonConvert.SerializeObject(userSettings, Formatting.Indented);
            File.WriteAllText(fileFullPath, output);
        }

        public void ApplyUserSettings(int UserID)
        {
            string fileFullPath = GlobalConfig.Instance.PathFileJS() + "UserSettings.json";
            string json = File.ReadAllText(fileFullPath);
            if (json == "")
            {
                CreateStandardUserSettingsJson(UserID);
            }
            JsonConvert.DeserializeObject<List<UserSetting>>(json).ForEach(item =>
            {
                if (item.UserId == UserID)
                {
                    ChangeVolumn(item.Volume * 10);
                    ChangeVoice(item.Voice == false ? Voice.Male : Voice.Female);
                }
            });
        }

        public UserSetting GetUserSettings(int UserID)
        {
            string fileFullPath = GlobalConfig.Instance.PathFileJS() + "UserSettings.json";
            string json = File.ReadAllText(fileFullPath);
            if (json == "")
            {
                CreateStandardUserSettingsJson(UserID);
            }
            List<UserSetting> userSettings = JsonConvert.DeserializeObject<List<UserSetting>>(json);
            UserSetting userSetting = userSettings.FirstOrDefault(p => p.UserId == UserID);
            if(userSetting == null)
            {
                UserSetting temp = new UserSetting()
                {
                    UserId = UserID,
                    Volume = 10,
                    Voice = false,
                    Goal = 45,
                };
                userSettings.Add(temp);
                string output = JsonConvert.SerializeObject(userSettings, Formatting.Indented);
                File.WriteAllText(fileFullPath, output);

                return temp;
            }
            else
            {
                return userSetting;
            }

        }

        public void SetUserGoal(int UserID, int Goal)
        {
            List<UserSetting> userSettings = new List<UserSetting>();
            string fileFullPath = GlobalConfig.Instance.PathFileJS() + "UserSettings.json";
            
            string json = File.ReadAllText(fileFullPath);
            if (json == "")
            {
                CreateStandardUserSettingsJson(UserID);
            }
            userSettings = JsonConvert.DeserializeObject<List<UserSetting>>(json);
            
            bool check = false;
            for (int i = 0; i < userSettings.Count; i++)
            {
                if (userSettings[i].UserId == UserID)
                {
                    userSettings[i].Goal = Goal;
                    check = true;
                    break;
                }
            }
            if (check == false)
            {
                userSettings.Add(new UserSetting()
                {
                    UserId = UserID,
                    Volume = 10,
                    Voice = false,
                    Goal = Goal,

                });
            }

            string output = JsonConvert.SerializeObject(userSettings, Formatting.Indented);
            File.WriteAllText(fileFullPath, output);
        }

        public void SetUserSettings(int UserID, int Volume, bool Voice)
        {
            List<UserSetting> userSettings = new List<UserSetting>();
            string fileFullPath = GlobalConfig.Instance.PathFileJS() + "UserSettings.json"; 
            string json = File.ReadAllText(fileFullPath);
            if (json == "")
            {
                CreateStandardUserSettingsJson(UserID);
            }
            userSettings = JsonConvert.DeserializeObject<List<UserSetting>>(json);
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

    public class UserSetting 
    {
        public int UserId { set; get; }
        public int Volume { set; get; }
        public bool Voice { set; get; } // false: Male; true: Female
        public int Goal { set; get; }
    }

}

