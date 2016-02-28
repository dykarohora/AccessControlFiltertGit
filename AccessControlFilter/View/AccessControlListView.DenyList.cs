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
        private void button_denyListClear_Click(object sender, EventArgs e)
        {
            aclModel.ClearDenyList();
            UpdateDenyList();
        }

        private void button_denyListDelete_Click(object sender, EventArgs e)
        {
            List<string> targetDomainList =
                GetSelectedDomainList(dataGridView_DenyList.SelectedCells);
            aclModel.DeleteRowFromDenyList(targetDomainList);
            UpdateDenyList();
        }

        private void button_denyListMoveAllow_Click(object sender, EventArgs e)
        {
            List<string> targetDomainList =
                GetSelectedDomainList(dataGridView_DenyList.SelectedCells);
            aclModel.MoveToAllowListFromDenyList(targetDomainList);
            UpdateACLView();
        }
    }
}
