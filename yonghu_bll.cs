using System;
using System.Data;
using C_大作业.DAL;
using C_大作业.MODEL;

namespace C_大作业.BLL
{
    public class yonghu_bll
    {
        private readonly yonghu_dal dal = new yonghu_dal();

        public yonghu denglu(string yonghu_ming, string mima_hash)
        {
            return dal.GetByMingAndMima(yonghu_ming, mima_hash);
        }

        public yonghu Login(string username, string password)
        {
            return dal.GetByMingAndMima(username, password);
        }

        public DataTable GetAllUsers()
        {
            return dal.GetAllUsers();
        }

        public DataTable SearchUsers(string keyword)
        {
            return dal.SearchUsers(keyword);
        }

        public void AddUser(string username, string password, string realname)
        {
            dal.AddUser(username, password, realname);
        }
    }
}
