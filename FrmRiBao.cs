using System;
using System.Data;
using System.Windows.Forms;

namespace C_大作业.UI
{
    public partial class FrmRiBao : Form
    {
        public FrmRiBao()
        {
            InitializeComponent();
        }

        private void FrmRiBao_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            LoadDailyReport();
        }

        private void LoadDailyReport()
        {
            try
            {
                // 模拟日报数据
                DataTable dt = new DataTable();
                dt.Columns.Add("时间段", typeof(string));
                dt.Columns.Add("订单数", typeof(int));
                dt.Columns.Add("营业额", typeof(decimal));
                dt.Columns.Add("会员消费", typeof(decimal));
                dt.Columns.Add("现金收入", typeof(decimal));
                dt.Columns.Add("在线支付", typeof(decimal));

                // 添加示例数据（按时段统计）
                dt.Rows.Add("09:00-12:00", 15, 520.00m, 280.00m, 100.00m, 420.00m);
                dt.Rows.Add("12:00-15:00", 28, 980.00m, 450.00m, 200.00m, 780.00m);
                dt.Rows.Add("15:00-18:00", 22, 760.00m, 380.00m, 150.00m, 610.00m);
                dt.Rows.Add("18:00-21:00", 35, 1250.00m, 680.00m, 300.00m, 950.00m);

                dgvDetails.DataSource = dt;

                // 计算汇总数据
                int totalOrders = 0;
                decimal totalIncome = 0;
                int memberOrders = 0;

                foreach (DataRow row in dt.Rows)
                {
                    totalOrders += Convert.ToInt32(row["订单数"]);
                    totalIncome += Convert.ToDecimal(row["营业额"]);
                    if (Convert.ToDecimal(row["会员消费"]) > 0)
                    {
                        memberOrders++;
                    }
                }

                decimal avgAmount = totalOrders > 0 ? totalIncome / totalOrders : 0;

                // 更新汇总信息
                lblTotalIncome.Text = $"营业额\r\n￥{totalIncome:F2}";
                lblOrderCount.Text = $"订单数\r\n{totalOrders}";
                lblAvgAmount.Text = $"平均客单价\r\n￥{avgAmount:F2}";
                lblMemberCount.Text = $"会员消费\r\n{memberOrders * 8}笔";
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载日报数据失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime queryDate = dtpDate.Value.Date;
            MessageBox.Show($"查询 {queryDate:yyyy年MM月dd日} 的营业数据\n（功能开发中...）", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDailyReport();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DateTime queryDate = dtpDate.Value.Date;
            MessageBox.Show($"导出 {queryDate:yyyy年MM月dd日} 的日报表\n（功能开发中...）", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
