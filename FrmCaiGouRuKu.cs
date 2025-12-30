using System;
using System.Data;
using System.Windows.Forms;

namespace C_大作业.UI
{
    public partial class FrmCaiGouRuKu : Form
    {
        public FrmCaiGouRuKu()
        {
            InitializeComponent();
        }

        private void FrmCaiGouRuKu_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            LoadPurchaseData();
        }

        private void LoadPurchaseData()
        {
            try
            {
                // 模拟采购入库数据
                DataTable dt = new DataTable();
                dt.Columns.Add("入库单号", typeof(string));
                dt.Columns.Add("入库日期", typeof(DateTime));
                dt.Columns.Add("供应商", typeof(string));
                dt.Columns.Add("商品数量", typeof(int));
                dt.Columns.Add("入库金额", typeof(decimal));
                dt.Columns.Add("经手人", typeof(string));
                dt.Columns.Add("备注", typeof(string));

                // 添加示例数据
                dt.Rows.Add("RK202412270001", DateTime.Now, "奶茶原料供应商A", 50, 1500.00m, "张三", "本月第一批采购");
                dt.Rows.Add("RK202412260002", DateTime.Now.AddDays(-1), "包装材料供应商B", 100, 500.00m, "李四", "杯子和吸管");
                dt.Rows.Add("RK202412250003", DateTime.Now.AddDays(-2), "水果供应商C", 30, 800.00m, "王五", "新鲜水果");

                dgvPurchase.DataSource = dt;
                
                // 计算合计
                decimal total = 0;
                foreach (DataRow row in dt.Rows)
                {
                    total += Convert.ToDecimal(row["入库金额"]);
                }
                lblTotalAmount.Text = $"共 {dt.Rows.Count} 条，合计：￥{total:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载数据失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime queryDate = dtpDate.Value.Date;
            MessageBox.Show($"查询 {queryDate:yyyy-MM-dd} 的入库记录\n（功能开发中...）", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadPurchaseData();
        }

        private void btnNewPurchase_Click(object sender, EventArgs e)
        {
            MessageBox.Show("新增入库单功能开发中...\n可添加采购商品明细、供应商信息等", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (dgvPurchase.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择要查看的入库单", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string purchaseNo = dgvPurchase.SelectedRows[0].Cells["入库单号"].Value.ToString();
            MessageBox.Show($"入库单详情：{purchaseNo}\n（详情页面开发中...）", "入库单详情", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPurchase.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择要删除的入库单", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("确定要删除选中的入库单吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("删除功能开发中...", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvPurchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
