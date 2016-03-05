using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControlFilter.View
{
    public partial class AccessControlListView
    {
        private void button_allowListClear_Click(object sender, EventArgs e)
        {
            aclModel.ClearAllowList();
            UpdateAllowList();
        }

        private void button_allowListDelete_Click(object sender, EventArgs e)
        {
            List<string> targetDomainList = 
                GetSelectedDomainList(dataGridView_AllowList.SelectedCells);
            aclModel.DeleteRowFromAllowList(targetDomainList);
            UpdateAllowList();
        }

        private void button_allowListMoveDeny_Click(object sender, EventArgs e)
        {
            //選択している行のドメインリストを作る
            List<string> targetDomainList =
                GetSelectedDomainList(dataGridView_AllowList.SelectedCells);
            //ACLモデルにドメインのリストを渡す
            aclModel.MoveToDenyListFromAllowList(targetDomainList);
            //AllowListとDenyListの描画をアップデート
            UpdateACLView();
        }
    }
}
