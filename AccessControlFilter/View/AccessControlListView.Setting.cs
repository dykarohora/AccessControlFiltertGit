using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessControlFilter.Model.enums;

namespace AccessControlFilter.View
{
    public partial class AccessControlListView
    {
        private void radioButton_filterEnable_CheckedChanged(object sender, EventArgs e)
        {
            //SettingModelにアクセスし、フィルタを有効化する
            if (configModel.IsEnableFilter == false)
            {
                configModel.EnableFilter();
                groupBox_allowList.Enabled = true;
                groupBox_denyList.Enabled = true;
            }
        }

        private void radioButton_filterDisable_CheckedChanged(object sender, EventArgs e)
        {
            //SettingModelにアクセスし、フィルタを無効化する
            if (configModel.IsEnableFilter == true)
            {
                configModel.DisableFilter();
                groupBox_allowList.Enabled = false;
                groupBox_denyList.Enabled = false;
            }
        }


        private void radioButton_modeManual_CheckedChanged(object sender, EventArgs e)
        {
            if (configModel.ActionMode != ACL_ActionMode.MANUAL_MODE)
                configModel.ChangeManualMode();

        }

        private void radioButton_modeWhiteList_CheckedChanged(object sender, EventArgs e)
        {
            if (configModel.ActionMode != ACL_ActionMode.WHITE_LIST_MODE)
                configModel.ChangeWhiteListMode();
        }

        private void radioButton_modeBlackList_CheckedChanged(object sender, EventArgs e)
        {
            if (configModel.ActionMode != ACL_ActionMode.BLACK_LIST_MODE)
                configModel.ChangeBlackListMode();
        }

        private void radioButton_hideSessionEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (configModel.IsEnableHideSession == false)
                configModel.EnableHideSession();
        }

        private void radioButton_hideSessionDisable_CheckedChanged(object sender, EventArgs e)
        {
            if (configModel.IsEnableHideSession == true)
                configModel.DisableHideSession();
        }
    }
}
