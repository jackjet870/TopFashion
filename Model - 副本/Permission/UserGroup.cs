using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace TopFashion
{
    /// <summary>
    /// ��ʾ��User������ɵļ���
    /// </summary>
    [Serializable]
    public class UserGroup : IArchitecture//, ICollection
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        public UserGroup()
        {
            roles = new List<int>();
        }

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public UserGroup(int id, string name)
        {
            this.id = id;
            if (name != null && name.Trim() != "")
                this.name = name;
            roles = new List<int>();
        }

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="roles"></param>
        public UserGroup(int id, string name, List<int> roles)
        {
            this.id = id;
            if (name != null && name.Trim() != "")
                this.name = name;
            if (roles == null)
                this.roles = new List<int>();
            else
                this.roles = roles;
        }

        /// <summary>
        /// ���ػ����ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name;
        }

        int id;

        /// <summary>
        /// �û���ID
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        List<int> roles;

        /// <summary>
        /// �û���ӵ�еĽ�ɫ����
        /// </summary>
        public List<int> Roles
        {
            get { return roles; }
            set
            {
                if (value != null)
                    roles = value;
            }
        }

        string name = "δ�����û���";

        /// <summary>
        /// �û��������
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null && value.Trim() != "")
                    name = value;
            }
        }
        string remark;

        /// <summary>
        /// �û�������
        /// </summary>
        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        //private ArrayList list = new ArrayList();

        ///// <summary>
        ///// ������
        ///// </summary>
        ///// <param name="index"></param>
        ///// <returns></returns>
        //public User this[int index]
        //{
        //    get
        //    {
        //        return (User)this.list[index];
        //    }
        //    set
        //    {
        //        this.list[index] = value;
        //    }
        //}

        ///// <summary>
        ///// �򼯺������Ԫ��
        ///// </summary>
        ///// <param name="item"></param>
        ///// <returns></returns>
        //public int Add(User item)
        //{
        //    return this.list.Add(item);
        //}

        ///// <summary>
        ///// �Ӽ������Ƴ�ָ��Ԫ��
        ///// </summary>
        ///// <param name="item"></param>
        //public void Remove(User item)
        //{
        //    this.list.Remove(item);
        //}

        ///// <summary>
        ///// �Ӽ������Ƴ�ָ��������Ԫ��
        ///// </summary>
        ///// <param name="index"></param>
        //public void RemoveAt(int index)
        //{
        //    this.list.RemoveAt(index);
        //}

        ///// <summary>
        ///// ȡ�ü���Ԫ�ظ���
        ///// </summary>
        //public int Count
        //{
        //    get
        //    {
        //        return this.list.Count;
        //    }
        //}

        //#region ICollection ��Ա

        //void ICollection.CopyTo(Array array, int index)
        //{
        //    this.list.CopyTo(array, index);
        //}

        //int ICollection.Count
        //{
        //    get { return this.list.Count; }
        //}

        //bool ICollection.IsSynchronized
        //{
        //    get { return this.list.IsSynchronized; }
        //}

        //object ICollection.SyncRoot
        //{
        //    get { return this.list.SyncRoot; }
        //}

        //#endregion

        //#region IEnumerable ��Ա

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return this.list.GetEnumerator();
        //}

        //#endregion
    }

    public static class UserGroupListExtensions
    {
        public static bool ContainsUserGroup(this List<UserGroup> ugs, UserGroup ug)
        {
            foreach (UserGroup u in ugs)
            {
                if (u.ID == ug.ID)
                    return true;
            }
            return false;
        }

        public static bool ContainsUserGroup(this List<int> ugs, int ug)
        {
            return ugs.Contains(ug);
        }
    }
}
