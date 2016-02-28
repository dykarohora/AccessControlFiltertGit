using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiddler;
using AccessControlFilter.View;
using System.Windows.Forms;
using AccessControlFilter.Model;

[assembly: Fiddler.RequiredVersion("4.0.0.0")]

namespace AccessControlFilter
{
    public class ACLExtensionController : IAutoTamper
    {
        private TabPage oPage;
        private AccessControlListView aclView;
        private AccessControlListModel aclModel;
        private ConfigModel configModel;

        public ACLExtensionController()
        {
            oPage = new TabPage("ACL Filter");
            aclView = new View.AccessControlListView();
            aclView.Dock = DockStyle.Fill;
            oPage.Controls.Add(aclView);
            
            FiddlerApplication.UI.tabsViews.TabPages.Add(oPage);
            aclModel = AccessControlListModel.GetInstance();
            configModel = ConfigModel.GetInstance();
        }

        public void OnLoad() {
            
        }

        public void AutoTamperRequestBefore(Session oSession) {
            if (configModel.IsEnableFilter)
            {
                //飛んできたセッションからドメインを取得する
                string domain = oSession.hostname;

                lock (aclModel)
                {
                    //取得したドメインがListに入っているかチェックする
                    //Listに入っていなければメッセージボックスを表示する
                    if (!aclModel.IsContainAllowList(domain) && !aclModel.IsContainDenyList(domain))
                    {
                        //UIスレッドを止めたい
                        if ((MessageBox.Show(domain + "への接続を許可しますか",
                            "確認", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly)) == DialogResult.Yes)
                        {
                            aclModel.AddAllowList(domain);
                        }
                        else
                        {
                            aclModel.AddDenyList(domain);
                        }
                        aclView.UpdateACLView();
                    }
                }


                //Deny Listに入っている場合はセッションをドロップする。
                if (aclModel.IsContainDenyList(domain))
                {
                    oSession.oRequest.FailSession(500, "Block", "ACLFilter");
                }
            }
        }

        public void AutoTamperRequestAfter(Session oSession) {

        }



        public void AutoTamperResponseAfter(Session oSession) { }

        public void AutoTamperResponseBefore(Session oSession) { }

        public void OnBeforeReturningError(Session oSession) { }

        public void OnBeforeUnload() { }
    }
}
