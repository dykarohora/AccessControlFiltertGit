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
        public ACL_ActionMode ActionMode { get; private set; } = ACL_ActionMode.MANUAL_MODE;
        public bool IsEnableHideSession { get; private set; } = false;

        private ConfigModel() { }

        internal static ConfigModel GetInstance()
        {
            return _settingModel;
        }

        internal bool EnableFilter()
        {
            if (IsEnableFilter == false)
                IsEnableFilter = true;
            else
                return false;

            return true;
        }

        internal bool DisableFilter()
        {
            if (IsEnableFilter == true)
                IsEnableFilter = false;
            else
                return false;

            return true;
        }

        internal void ChangeManualMode()
        {
            if (ActionMode != ACL_ActionMode.MANUAL_MODE)
                ActionMode = ACL_ActionMode.MANUAL_MODE;
        }

        internal void ChangeWhiteListMode()
        {
            if (ActionMode != ACL_ActionMode.WHITE_LIST_MODE)
                ActionMode = ACL_ActionMode.WHITE_LIST_MODE;
        }

        internal void ChangeBlackListMode()
        {
            if (ActionMode != ACL_ActionMode.BLACK_LIST_MODE)
                ActionMode = ACL_ActionMode.BLACK_LIST_MODE;
        }

        internal void EnableHideSession()
        {
            if (IsEnableHideSession == false)
                IsEnableHideSession = true;
        }

        internal void DisableHideSession()
        {
            if (IsEnableHideSession == true)
                IsEnableHideSession = false;
        }
    }
}
