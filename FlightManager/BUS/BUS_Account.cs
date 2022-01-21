using FlightManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FlightManager.BUS
{
    class BUS_Account
    {
        DAO_Account dAO_Account;
        public BUS_Account()
        {
            dAO_Account = new DAO_Account();
        }
        public void ListAccount(DataGridView dg)
        {
            dg.DataSource = dAO_Account.ListAccount();
        }
        public void ListAccount (ComboBox cb)
        {
            cb.DataSource = dAO_Account.ListAccount();
            cb.DisplayMember = "user_role";
            cb.ValueMember = "active";
        }
        public int Add_Account(account account)
        {
            if (dAO_Account.CheckAccount(account.account_id))
            {
                return 0;
            }
            else
            {
                try
                {
                    dAO_Account.Add_Account(account);
                    return 1;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
        public int Delete_Account(int account_id)
        {
            try
            {
                if (dAO_Account.CheckAccount(account_id))
                {
                    dAO_Account.Delete_Account(account_id);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int Update_Account(account account)
        {
            if (dAO_Account.CheckAccount(account.account_id))
            {
                try
                {
                    dAO_Account.Update_Account(account);
                    return 1;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
            return 0;
        }
        MD5 md = MD5.Create();
        private void Password(string password)
        {
            byte[] inputstr = System.Text.Encoding.ASCII.GetBytes(password);
            byte[] hash = md.ComputeHash(inputstr);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
        }
    }
}
