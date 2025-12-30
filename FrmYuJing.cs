using System;
using System.Drawing;
using System.Windows.Forms;
using C_大作业.BLL;

namespace C_大作业.UI
{
    public partial class FrmYuJing : Form
    {
        public FrmYuJing()
        {
            InitializeComponent();
        }

        private void FrmYuJing_Load(object sender, EventArgs e)
        {
            // 设置DataGridView样式
            dgvKuCun.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 140, 0);
            dgvKuCun.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKuCun.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 13F, FontStyle.Bold);
            dgvKuCun.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKuCun.DefaultCellStyle.Font = new Font("微软雅黑", 13F);
            dgvKuCun.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            LoadKuCun();
        }

        private void LoadKuCun()
        {
            try
            {
                dgvKuCun.DataSource = new kucun_bll().GetWarning();
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载库存失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKuCun_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            HighlightLowStock();
        }

        private void HighlightLowStock()
        {
            foreach (DataGridViewRow row in dgvKuCun.Rows)
            {
                if (row.IsNewRow) continue;
                try
                {
                    var qty = Convert.ToDecimal(row.Cells[3].Value);
                    var safe = Convert.ToDecimal(row.Cells[4].Value);
                    if (qty < safe)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(180, 0, 0);
                        row.DefaultCellStyle.Font = new Font("微软雅黑", 13F, FontStyle.Bold);
                    }
                }
                catch { }
            }
        }

        private void dgvKuCun_DoubleClick(object sender, EventArgs e)
        {
            if (dgvKuCun.SelectedRows.Count == 0) return;
            
            var row = dgvKuCun.SelectedRows[0];
            var name = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "";
            
            var input = ShowInputDialog("请输入【" + name + "】的补货数量：", "补货", "100");
            decimal amount;
            
            if (decimal.TryParse(input, out amount) && amount > 0)
            {
                try
                {
                    new kucun_bll().BuHuo(amount);
                    MessageBox.Show("补货成功！+" + amount, "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKuCun();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("补货失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadKuCun();
        }

        private void btnBatchRestock_Click(object sender, EventArgs e)
        {
            try
            {
                new kucun_bll().BuHuo(1000);
                MessageBox.Show("批量补货成功！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKuCun();
            }
            catch (Exception ex)
            {
                MessageBox.Show("补货失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ShowInputDialog(string prompt, string title, string defaultValue)
        {
            var form = new Form
            {
                Width = 400,
                Height = 180,
                Text = title,
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };
            
            var lbl = new Label { Text = prompt, Left = 20, Top = 20, Width = 340, AutoSize = true };
            var txt = new TextBox { Text = defaultValue, Left = 20, Top = 50, Width = 340 };
            var btnOk = new Button { Text = "确定", Left = 180, Top = 90, Width = 80, DialogResult = DialogResult.OK };
            var btnCancel = new Button { Text = "取消", Left = 280, Top = 90, Width = 80, DialogResult = DialogResult.Cancel };
            
            form.Controls.AddRange(new Control[] { lbl, txt, btnOk, btnCancel });
            form.AcceptButton = btnOk;
            
            return form.ShowDialog() == DialogResult.OK ? txt.Text : "";
        }
    }
}
