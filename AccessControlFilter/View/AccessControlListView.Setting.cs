using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                groupBox_modeSetting.Enabled = true;
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
                groupBox_modeSetting.Enabled = false;
                groupBox_allowList.Enabled = false;
                groupBox_denyList.Enabled = false;
            }
        }
    }
}
