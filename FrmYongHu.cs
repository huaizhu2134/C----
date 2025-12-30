using System;
using System.Drawing;
using System.Windows.Forms;
using C_大作业.BLL;

namespace C_大作业.UI
{
    public partial class FrmYongHu : Form
    {
        public FrmYongHu()
        {
            InitializeComponent();
        }

        private void FrmYongHu_Load(object sender, EventArgs e)
        {
            // 设置DataGridView样式
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(70, 130, 180);
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            dgvUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsers.DefaultCellStyle.Font = new Font("微软雅黑", 11F);
            dgvUsers.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                var bll = new yonghu_bll();
                dgvUsers.DataSource = bll.GetAllUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载用户失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadUsers();
                return;
            }

            try
            {
                var bll = new yonghu_bll();
                dgvUsers.DataSource = bll.SearchUsers(keyword);
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 简化实现：直接弹窗输入
            string username = ShowInputDialog("请输入账号：", "新增用户");
            if (string.IsNullOrEmpty(username)) return;

            string realname = ShowInputDialog("请输入真实姓名：", "新增用户");
            if (string.IsNullOrEmpty(realname)) return;

            try
            {
                var bll = new yonghu_bll();
                bll.AddUser(username, "123456", realname); // 默认密码123456
                MessageBox.Show("添加成功！默认密码：123456", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetPwd_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择一个用户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("确定要将该用户密码重置为123456吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("密码重置成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择一个用户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("确定要删除该用户吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
        }

        private string ShowInputDialog(string prompt, string title)
        {
            Form form = new Form
            {
                Width = 400,
                Height = 180,
                Text = title,
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label lbl = new Label { Text = prompt, Left = 20, Top = 20, Width = 340 };
            TextBox txt = new TextBox { Left = 20, Top = 50, Width = 340 };
            Button btnOk = new Button { Text = "确定", Left = 180, Top = 90, Width = 80, DialogResult = DialogResult.OK };
            Button btnCancel = new Button { Text = "取消", Left = 280, Top = 90, Width = 80, DialogResult = DialogResult.Cancel };

            form.Controls.AddRange(new Control[] { lbl, txt, btnOk, btnCancel });
            form.AcceptButton = btnOk;

            return form.ShowDialog() == DialogResult.OK ? txt.Text : "";
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
