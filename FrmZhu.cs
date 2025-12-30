using System;
using System.Drawing;
using System.Windows.Forms;
using C_大作业.MODEL;

namespace C_大作业.UI
{
    public partial class FrmZhu : Form
    {
        private yonghu currentUser;

        public FrmZhu(yonghu dangqian_yonghu)
        {
            InitializeComponent();
            currentUser = dangqian_yonghu;
        }

        private void FrmZhu_Load(object sender, EventArgs e)
        {
            // 显示当前用户
            if (currentUser != null)
            {
                lblUser.Text = "当前员工：" + currentUser.zhenshi_name;
            }
            // 默认显示收银台
            btnShouYin_Click(null, null);
        }

        #region 菜单按钮事件

        private void btnShouYin_Click(object sender, EventArgs e)
        {
            SetMenuActive(btnShouYin);
            pnlContent.Controls.Clear();
            
            var frm = new FrmShouYin
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlContent.Controls.Add(frm);
            frm.Show();
        }

        private void btnHuiYuan_Click(object sender, EventArgs e)
        {
            SetMenuActive(btnHuiYuan);
            pnlContent.Controls.Clear();
            
            var frm = new FrmHuiYuan
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlContent.Controls.Add(frm);
            frm.Show();
        }

        private void btnKuCun_Click(object sender, EventArgs e)
        {
            SetMenuActive(btnKuCun);
            pnlContent.Controls.Clear();
            
            var frm = new FrmYuJing
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlContent.Controls.Add(frm);
            frm.Show();
        }

        private void btnTongJi_Click(object sender, EventArgs e)
        {
            SetMenuActive(btnTongJi);
            pnlContent.Controls.Clear();
            
            var frm = new FrmTongJi
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlContent.Controls.Add(frm);
            frm.Show();
        }

        private void btnYongHu_Click(object sender, EventArgs e)
        {
            SetMenuActive(btnYongHu);
            pnlContent.Controls.Clear();
            
            var frm = new FrmYongHu
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlContent.Controls.Add(frm);
            frm.Show();
        }

        private void btnChanPin_Click(object sender, EventArgs e)
        {
            SetMenuActive(btnChanPin);
            pnlContent.Controls.Clear();
            
            var frm = new FrmChanPin
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlContent.Controls.Add(frm);
            frm.Show();
        }

        private void btnCaiGou_Click(object sender, EventArgs e)
        {
            SetMenuActive(btnCaiGou);
            pnlContent.Controls.Clear();
            
            var frm = new FrmCaiGouRuKu
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlContent.Controls.Add(frm);
            frm.Show();
        }

        private void btnDingDan_Click(object sender, EventArgs e)
        {
            SetMenuActive(btnDingDan);
            pnlContent.Controls.Clear();
            
            var frm = new FrmDingDanChaXun
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlContent.Controls.Add(frm);
            frm.Show();
        }

        private void btnRiBao_Click(object sender, EventArgs e)
        {
            SetMenuActive(btnRiBao);
            pnlContent.Controls.Clear();
            
            var frm = new FrmRiBao
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlContent.Controls.Add(frm);
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetMenuActive(Button activeBtn)
        {
            // 重置所有按钮颜色
            btnShouYin.BackColor = Color.FromArgb(60, 60, 60);
            btnHuiYuan.BackColor = Color.FromArgb(60, 60, 60);
            btnKuCun.BackColor = Color.FromArgb(60, 60, 60);
            btnTongJi.BackColor = Color.FromArgb(60, 60, 60);
            btnYongHu.BackColor = Color.FromArgb(60, 60, 60);
            btnChanPin.BackColor = Color.FromArgb(60, 60, 60);
            btnCaiGou.BackColor = Color.FromArgb(60, 60, 60);
            btnDingDan.BackColor = Color.FromArgb(60, 60, 60);
            btnRiBao.BackColor = Color.FromArgb(60, 60, 60);
            // 高亮当前按钮
            activeBtn.BackColor = Color.FromArgb(139, 90, 43);
        }

        #endregion

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
