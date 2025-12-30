using System;
using System.Data;
using System.Windows.Forms;

namespace C_大作业.UI
{
    public partial class FrmDingDanChaXun : Form
    {
        public FrmDingDanChaXun()
        {
            InitializeComponent();
        }

        private void FrmDingDanChaXun_Load(object sender, EventArgs e)
        {
            // 设置默认日期范围为最近7天
            dtpStartDate.Value = DateTime.Now.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                // 模拟订单数据
                DataTable dt = new DataTable();
                dt.Columns.Add("订单号", typeof(string));
                dt.Columns.Add("下单时间", typeof(DateTime));
                dt.Columns.Add("会员名称", typeof(string));
                dt.Columns.Add("订单金额", typeof(decimal));
                dt.Columns.Add("支付方式", typeof(string));
                dt.Columns.Add("订单状态", typeof(string));

                // 添加示例数据
                dt.Rows.Add("DD202412270001", DateTime.Now.AddHours(-2), "张三", 38.5m, "微信支付", "已完成");
                dt.Rows.Add("DD202412270002", DateTime.Now.AddHours(-1), "李四", 52.0m, "支付宝", "已完成");
                dt.Rows.Add("DD202412260003", DateTime.Now.AddDays(-1), "王五", 28.0m, "现金", "已完成");

                dgvOrders.DataSource = dt;
                lblTotal.Text = $"共 {dt.Rows.Count} 条订单";
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载订单数据失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1);
                string orderNo = txtOrderNo.Text.Trim();

                // 这里应该调用BLL层查询订单
                // 暂时使用模拟数据
                LoadOrders();
                
                MessageBox.Show("查询功能开发中...", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择要查看的订单", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string orderNo = dgvOrders.SelectedRows[0].Cells["订单号"].Value.ToString();
            MessageBox.Show($"订单详情：{orderNo}\n（详情页面开发中...）", "订单详情", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("导出功能开发中...", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtOrderNo_Enter(object sender, EventArgs e)
        {
            if (txtOrderNo.Text == "订单号")
            {
                txtOrderNo.Text = "";
                txtOrderNo.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtOrderNo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderNo.Text))
            {
                txtOrderNo.Text = "订单号";
                txtOrderNo.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
