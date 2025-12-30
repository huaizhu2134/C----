using System;
using System.Data;
using C_大作业.DAL;

namespace C_大作业.BLL
{
    public class kucun_bll
    {
        private readonly kucun_dal dal = new kucun_dal();

        public DataTable GetWarning()
        {
            return dal.GetWarning();
        }

        public void BuHuo(decimal liang)
        {
            dal.BuHuo(liang);
        }
    }
}
