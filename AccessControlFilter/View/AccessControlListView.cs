using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessControlFilter.Model;

namespace AccessControlFilter.View
{
    public partial class AccessControlListView : UserControl
    {
        private AccessControlListModel aclModel;
        private ConfigModel configModel;

        public AccessControlListView()
        {
            InitializeComponent();
            aclModel = AccessControlListModel.GetInstance();
            configModel = ConfigModel.GetInstance();
        }

        //共通処理
        /// <summary>
        /// 選択した行からドメインのリストを作成する
        /// </summary>
        /// <param name="selectedCells"></param>
        /// <returns></returns>
        private List<string> GetSelectedDomainList(DataGridViewSelectedCellCollection selectedCells)
        {
            List<string> resultDomainList = new List<string>();
            foreach (DataGridViewCell cell in selectedCells)
                resultDomainList.Add(cell.Value.ToString());

            return resultDomainList;
        }

        /// <summary>
        /// ACLリストの描画アップデート
        /// </summary>
        public void UpdateACLView()
        {
            UpdateAllowList();
            UpdateDenyList();
        }

        /// <summary>
        /// Allowリストの描画アップデート
        /// </summary>
        private void UpdateAllowList()
        {
            //AllowListをいったんクリアする
            dataGridView_AllowList.Rows.Clear();
            //AllowListを描画する
            List<string> allowList = aclModel.AllowList;
            foreach(var domain in allowList)
            {
                dataGridView_AllowList.Rows.Add();
                int idx = dataGridView_AllowList.Rows.Count - 1;
                dataGridView_AllowList.Rows[idx].Cells[0].Value = domain;
            }
        }

        /// <summary>
        /// Denyリストの描画アップデート
        /// </summary>
        private void UpdateDenyList()
        {
            dataGridView_DenyList.Rows.Clear();

            List<string> denyList = aclModel.DenyList;
            foreach(var domain in denyList)
            {
                dataGridView_DenyList.Rows.Add();
                int idx = dataGridView_DenyList.Rows.Count - 1;
                dataGridView_DenyList.Rows[idx].Cells[0].Value = domain;
            }
        }
    }
}
