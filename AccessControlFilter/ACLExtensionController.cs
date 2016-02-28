using AccessControlFilter.Model;
using AccessControlFilter.Model.enums;
using AccessControlFilter.View;
using Fiddler;
using System.Windows.Forms;

[assembly: Fiddler.RequiredVersion("4.0.0.0")]

namespace AccessControlFilter
{


    public class ACLExtensionController : IAutoTamper
    {
        private TabPage oPage;
        private AccessControlListView aclView;
        private AccessControlListModel aclModel;
        private ConfigModel configModel;

        delegate void AutoTamperRequestBeforeDelegate(Session oSession);
        AutoTamperRequestBeforeDelegate autoTamper;

        /// <summary>
        /// Viewの生成と、シングルトンなModelインスタンスの取得
        /// </summary>
        public ACLExtensionController()
        {
            oPage = new TabPage("ACL Filter");
            aclView = new AccessControlListView();
            aclView.Dock = DockStyle.Fill;
            oPage.Controls.Add(aclView);

            FiddlerApplication.UI.tabsViews.TabPages.Add(oPage);
            aclModel = AccessControlListModel.GetInstance();
            configModel = ConfigModel.GetInstance();
        }

        /// <summary>
        /// 動作モードに応じて実行するメソッドを切り替える
        /// </summary>
        /// <param name="oSession">キャプチャしたセッション</param>
        public void AutoTamperRequestBefore(Session oSession)
        {
            if (configModel.IsEnableFilter)
            {
                switch (configModel.ActionMode)
                {
                    case ACL_ActionMode.MANUAL_MODE:
                        autoTamper = AutoTamperRequestBegore_ManualMode;
                        break;

                    case ACL_ActionMode.WHITE_LIST_MODE:
                        autoTamper = AutoTamperRequestBefore_WhiteListMode;
                        break;

                    case ACL_ActionMode.BLACK_LIST_MODE:
                        autoTamper = AutoTamperRequestBefore_BlackListMode;
                        break;

                    default:
                        break;
                }
                if (autoTamper != null)
                    autoTamper(oSession);
            }
        }

        /// <summary>
        /// マニュアルモードでの動作。ACLに入っていない場合はメッセージボックスを表示し、
        /// Allow/Denyを選択させる。
        /// </summary>
        /// <param name="oSession"></param>
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

        /// <summary>
        /// ホワイトリストモードでの動作。セッションがAllowListに入っていない場合はセッションをドロップする。
        /// </summary>
        /// <param name="oSession"></param>
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

        /// <summary>
        /// ブラックリストモードでの動作。セッションがDenyListに入っている場合のみセッションをドロップする。
        /// </summary>
        /// <param name="oSession"></param>
        private void AutoTamperRequestBefore_BlackListMode(Session oSession)
        {
            //DenyListに含まれている場合は、セッションをドロップする
            if (aclModel.IsContainDenyList(oSession.hostname))
            {
                oSession.oRequest.FailSession(500, "Block", "ACLFilter");
                if (configModel.IsEnableHideSession)
                    oSession["ui-hide"] = "no";
            }
        }

        public void AutoTamperRequestAfter(Session oSession) { }

        public void AutoTamperResponseAfter(Session oSession) { }

        public void AutoTamperResponseBefore(Session oSession) { }

        public void OnBeforeReturningError(Session oSession) { }

        public void OnLoad() { }

        public void OnBeforeUnload() { }
    }
}
