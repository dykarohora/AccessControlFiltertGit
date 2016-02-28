using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiddler;
using AccessControlFilter.View;
using System.Windows.Forms;
using AccessControlFilter.Model;
using AccessControlFilter.Model.enums;

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

        public void OnLoad()
        {

        }

        private void AutoTamperRequestBegore_ManualMode(Session oSession)
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
            AutoTamperRequestBefore_BlackListMode(oSession);
        }

        private void AutoTamperRequestBefore_WhiteListMode(Session oSession)
        {
            //AllowListに含まれていない場合は、セッションをドロップする
            if (!aclModel.IsContainAllowList(oSession.hostname))
            {
                oSession.oRequest.FailSession(500, "Block", "ACLFilter");
                if (configModel.IsEnableHideSession)
                    oSession["ui-hide"] = "no";
            }
            
        }

        private void AutoTamperRequestBefore_BlackListMode(Session oSession)
        {
            //DenyListに含まれている場合は、セッションをドロップする
            if (aclModel.IsContainDenyList(oSession.hostname))
            {
                oSession.oRequest.FailSession(500, "Block", "ACLFilter");
                if(configModel.IsEnableHideSession)
                    oSession["ui-hide"] = "no";
            }
        }

        public void AutoTamperRequestBefore(Session oSession)
        {
            //oSession["ui-hide"] = "true";
            if (configModel.IsEnableFilter)
            {
                switch (configModel.ActionMode)
                {
                    case ACL_ActionMode.MANUAL_MODE:
                        AutoTamperRequestBegore_ManualMode(oSession);
                        break;

                    case ACL_ActionMode.WHITE_LIST_MODE:
                        AutoTamperRequestBefore_WhiteListMode(oSession);
                        break;

                    case ACL_ActionMode.BLACK_LIST_MODE:
                        AutoTamperRequestBefore_BlackListMode(oSession);
                        break;

                    default:
                        break;
                }
            }
        }

        public void AutoTamperRequestAfter(Session oSession) { }
        
        public void AutoTamperResponseAfter(Session oSession) { }

        public void AutoTamperResponseBefore(Session oSession) { }

        public void OnBeforeReturningError(Session oSession) { }

        public void OnBeforeUnload() { }
    }
}
