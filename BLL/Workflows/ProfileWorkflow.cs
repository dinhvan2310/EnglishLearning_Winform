using BLL.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Workflows
{
    public class ProfileWorkflow
    {
        public static ProfileWorkflow Instance
        {
            get
            {
                if (_Instance == null) 
                    _Instance = new ProfileWorkflow();
                return _Instance;
            }
        }

        private static ProfileWorkflow _Instance;

        private AccountManager _DataAccountAccess;
        private Validator _Validator;


        private ProfileWorkflow()
        {
            _DataAccountAccess = new AccountManager();
            _Validator = new Validator();
        }

        public DateTime? CheckDate(string date)
        {
            return _Validator.CheckDate(date);
        }
    }
}
