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
        public ActionMode actionMode { get; private set; } = ActionMode.MANUAL_MODE;

        private ConfigModel()
        {

        }

        public static ConfigModel GetInstance()
        {
            return _settingModel;
        }
        
        public void EnableFilter()
        {
            IsEnableFilter = true;
        }

        public void DisableFilter()
        {
            IsEnableFilter = false;
        }
        
    }
}
