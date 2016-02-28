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
            //Allowリストの描画を更新
            UpdateAllowList();
        }

        private void button_allowListDelete_Click(object sender, EventArgs e)
        {
            //選択している行のドメインリストを作る
            List<string> targetDomainList = 
                GetSelectedDomainList(dataGridView_AllowList.SelectedCells);
            //ACLモデルにインデックスのリストを渡す
            aclModel.DeleteRowFromAllowList(targetDomainList);
            //Allowリストの更新
            UpdateAllowList();
        }

        private void button_allowListMoveDeny_Click(object sender, EventArgs e)
        {
            //選択している行のドメインリストを作る
            List<string> targetDomainList =
                GetSelectedDomainList(dataGridView_AllowList.SelectedCells);
            //ACLモデルにドメインのリストを渡す

            //AllowListとDenyListの描画をアップデート
            UpdateACLView();
        }
    }
}
