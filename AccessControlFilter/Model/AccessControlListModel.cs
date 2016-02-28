using Fiddler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControlFilter.Model
{
    class AccessControlListModel
    {
        //フィールド
        internal List<string> AllowList { get; }
        internal List<string> DenyList { get; }

        //シングルトンパターン
        private static AccessControlListModel _aclModel = new AccessControlListModel();

        private AccessControlListModel()
        {
            AllowList = new List<string>();
            DenyList = new List<string>();
        }

        internal static AccessControlListModel GetInstance()
        {
            return _aclModel;
        }

        //メソッド
        //AllowListの操作
        internal bool IsContainAllowList(string domain)
        {
            return AllowList.Contains(domain);
        }

        internal void AddAllowList(string domain)
        {
            AllowList.Add(domain);
        }

        internal void ClearAllowList()
        {
            AllowList.Clear();
        }

        internal void DeleteRowFromAllowList(List<string> targetList)
        {
            foreach (var target in targetList)
                AllowList.Remove(target);
        }

        internal void MoveToDenyListFromAllowList(List<string> targetList)
        {
            foreach (var target in targetList)
                DenyList.Add(target);

            DeleteRowFromAllowList(targetList);
        }
        //DenyListの操作
        internal bool IsContainDenyList(string domain)
        {
            return DenyList.Contains(domain);
        }

        internal void AddDenyList(string domain)
        {
            DenyList.Add(domain);
        }

        internal void ClearDenyList()
        {
            DenyList.Clear();
        }

        internal void DeleteRowFromDenyList(List<string> targetList)
        {
            foreach (var target in targetList)
                DenyList.Remove(target);
        }

        internal void MoveToAllowListFromDenyList(List<string> targetList)
        {
            foreach (var target in targetList)
                AllowList.Add(target);

            DeleteRowFromDenyList(targetList);
        }
    }
}
