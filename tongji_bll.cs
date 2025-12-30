using System.Data;
using C_大作业.DAL;

namespace C_大作业.BLL
{
    public class tongji_bll
    {
        private readonly tongji_dal dal = new tongji_dal();

        public DataRow GetTodayStats()
        {
            return dal.GetTodayStats();
        }

        public DataTable GetHistoryStats()
        {
            return dal.GetHistoryStats();
        }

        public void RecordSale(int orderCount, int saleCount, decimal amount)
        {
            dal.UpdateTodayStats(orderCount, saleCount, amount);
        }
    }
}
