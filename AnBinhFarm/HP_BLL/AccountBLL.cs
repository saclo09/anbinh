using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HP_DAL;
using System.Collections;

namespace HP_BLL
{
    public class AccountBLL
    {
        public static Account getAcountbyIdUserName(string User)
        {
            List<Account> ds = AccountDAL.getListAccount();
            Account a = new Account();
            foreach (Account acc in ds)
            {
                if (acc.Username == User)
                { a = acc; break; }
            }
            return a;
        }
        public static Account getAcountbyId(int IDAcc)
        {
            List<Account> ds = AccountDAL.getListAccount();
            Account a = new Account();
            foreach (Account acc in ds)
            {
                if (acc.IdAccount == IDAcc)
                { a = acc; break; }
            }
            return a;
        }
        public static bool dangnhap(string username, string passW)
        {
            string passWMH = BLL.mahoa(passW);
            foreach (Account tk in getListAcountActive())
            {
                if (tk.Username == username && tk.Password == passWMH)
                    return true;
            }
            return false;
        }
        public static List<Account> getListAcount()
        {
            return AccountDAL.getListAccount();

        }
        public static List<Account> getListAcountActive()
        {
            List<Account> ds = AccountDAL.getListAccount();
            IEnumerable<Account> lsi = from Account ac in ds
                                       where ac.IsDelete != true
                                       select ac;
            return new List<Account>(lsi);
        }
        public static int insertAccount(string UserName, string Password, string FullName, string Phone, string Email, int GroupId, string CreateUser)
        {
            string Passwordmoi = BLL.mahoa(Password);
            return (AccountDAL.InsertAccount(UserName, Passwordmoi, FullName, Phone, Email, GroupId, CreateUser));
        }
        public static int upDateAccount(int IdAccount, string FullName, string Phone, string Email, int GroupId, bool IsDelete, string DeleteUser)
        {
            return AccountDAL.upDateAccount(IdAccount, FullName, Phone, Email, GroupId, IsDelete, DeleteUser);
        }
        public static int MyupDateAccount(int IdAccount, string Password, string FullName, string Phone, string Email)
        {
            return AccountDAL.MyupDateAccount(IdAccount, Password, FullName, Phone, Email);
        }
        public static int MyupDateAccountPass(int IdAccount, string Password, string FullName, string Phone, string Email)
        {
            string mypass = BLL.mahoa(Password);
            return AccountDAL.MyupDateAccount(IdAccount, mypass, FullName, Phone, Email);
        }
    }
}