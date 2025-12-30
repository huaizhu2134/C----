using System;
using System.Data;
using C_大作业.DAL;
using C_大作业.MODEL;

namespace C_大作业.BLL
{
    public class huiyuan_bll
    {
        private readonly huiyuan_dal dal = new huiyuan_dal();

        public string FaKa(string shouji, string xingming)
        {
            return dal.Create(shouji, xingming);
        }

        public DataTable GetAllMembers()
        {
            return dal.GetAllMembers();
        }

        public DataTable SearchByPhone(string shouji)
        {
            return dal.SearchByPhone(shouji);
        }

        public void Chongzhi(string shouji, decimal amount)
        {
            dal.Chongzhi(shouji, amount);
        }

        public DataTable SearchByNo(string memberNo)
        {
            return dal.SearchByNo(memberNo);
        }

        public void Recharge(int memberId, decimal amount, string payMethod)
        {
            dal.Recharge(memberId, amount, payMethod);
        }
    }
}
