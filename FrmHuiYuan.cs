using System;
using System.Drawing;
using System.Windows.Forms;
using C_大作业.BLL;

namespace C_大作业.UI
{
    public partial class FrmHuiYuan : Form
    {
        public FrmHuiYuan()
        {
            InitializeComponent();
        }

        private void FrmHuiYuan_Load(object sender, EventArgs e)
        {
            // 设置DataGridView样式
            dgvMembers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(70, 130, 180);
            dgvMembers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMembers.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            dgvMembers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMembers.DefaultCellStyle.Font = new Font("微软雅黑", 12F);
            dgvMembers.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            // 加载所有会员
            LoadMembers();
        }

        private void LoadMembers()
        {
            try
            {
                var bll = new huiyuan_bll();
                dgvMembers.DataSource = bll.GetAllMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载会员失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var phone = txtPhone.Text.Trim();
            var name = txtName.Text.Trim();
            
            if (string.IsNullOrEmpty(phone) || phone.Length != 11)
            {
                MessageBox.Show("请输入11位手机号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("请输入姓名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            try
            {
                var bll = new huiyuan_bll();
                var id = bll.FaKa(phone, name);
                MessageBox.Show("注册成功！会员卡号：" + id, "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Clear();
                txtName.Clear();
                LoadMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("注册失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var bll = new huiyuan_bll();
                var phone = txtPhone.Text.Trim();
                dgvMembers.DataSource = string.IsNullOrEmpty(phone) ? bll.GetAllMembers() : bll.SearchByPhone(phone);
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
