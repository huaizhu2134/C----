using System;
using System.Drawing;
using System.Windows.Forms;
using C_大作业.BLL;

namespace C_大作业.UI
{
    public partial class FrmTongJi : Form
    {
        public FrmTongJi()
        {
            InitializeComponent();
        }

        private void FrmTongJi_Load(object sender, EventArgs e)
        {
            // 设置DataGridView样式
            dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(138, 43, 226);
            dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistory.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            dgvHistory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHistory.DefaultCellStyle.Font = new Font("微软雅黑", 12F);
            dgvHistory.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var tongji = new tongji_bll();
                
                // 加载今日数据
                var today = tongji.GetTodayStats();
                if (today != null)
                {
                    lblOrdersValue.Text = today["dingdan_shu"].ToString();
                    lblSalesValue.Text = today["xiaoliang"].ToString();
                    lblAmountValue.Text = Convert.ToDecimal(today["yingye_e"]).ToString("0.00");
                }
                
                // 加载历史数据
                dgvHistory.DataSource = tongji.GetHistoryStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载数据失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
