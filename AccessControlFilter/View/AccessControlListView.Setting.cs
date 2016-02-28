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

        /// <summary>
        /// Filter Activateグループのラジオボタンイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_filterEnable_CheckedChanged(object sender, EventArgs e)
        {
            //SettingModelにアクセスし、フィルタを有効化する
            if (configModel.EnableFilter())
            {
                groupBox_allowList.Enabled = true;
                groupBox_denyList.Enabled = true;
            }
        }

        private void radioButton_filterDisable_CheckedChanged(object sender, EventArgs e)
        {
            //SettingModelにアクセスし、フィルタを無効化する
            if (configModel.DisableFilter())
            {
                groupBox_allowList.Enabled = false;
                groupBox_denyList.Enabled = false;
            }
        }

        /// <summary>
        /// Mode Settingグループのラジオボタンイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_modeManual_CheckedChanged(object sender, EventArgs e)
        {
            configModel.ChangeManualMode();
        }

        private void radioButton_modeWhiteList_CheckedChanged(object sender, EventArgs e)
        {
            configModel.ChangeWhiteListMode();
        }

        private void radioButton_modeBlackList_CheckedChanged(object sender, EventArgs e)
        {
            configModel.ChangeBlackListMode();
        }

        /// <summary>
        /// Hide Sessionグループのラジオボタンイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_hideSessionEnable_CheckedChanged(object sender, EventArgs e)
        {
            configModel.EnableHideSession();
        }

        private void radioButton_hideSessionDisable_CheckedChanged(object sender, EventArgs e)
        {
            configModel.DisableHideSession();
        }
    }
}
