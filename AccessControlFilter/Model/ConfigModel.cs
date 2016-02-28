using AccessControlFilter.Model.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControlFilter.Model
{
    class ConfigModel
    {

        private static ConfigModel _settingModel = new ConfigModel();

        public bool IsEnableFilter { get; private set; } = false;
        public ACL_ActionMode ActionMode { get; set; } = ACL_ActionMode.MANUAL_MODE;

        private ConfigModel()
        {

        }

        internal static ConfigModel GetInstance()
        {
            return _settingModel;
        }

        internal void EnableFilter()
        {
            IsEnableFilter = true;
        }

        internal void DisableFilter()
        {
            IsEnableFilter = false;
        }
        
        internal void ChangeManualMode()
        {
            ActionMode = ACL_ActionMode.MANUAL_MODE; 
        }

        internal void ChangeWhiteListMode()
        {
            ActionMode = ACL_ActionMode.WHITE_LIST_MODE;
        }

        internal void ChangeBlackListMode()
        {
            ActionMode = ACL_ActionMode.BLACK_LIST_MODE;
        }
    }
}
