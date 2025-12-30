using System;
using System.Windows.Forms;
using C_大作业.BLL;

namespace C_大作业.UI
{
    public partial class FrmHuiYuanChongZhi : Form
    {
        private int _memberId = 0;

        public FrmHuiYuanChongZhi()
        {
            InitializeComponent();
        }

        private void FrmHuiYuanChongZhi_Load(object sender, EventArgs e)
        {
            cmbPayMethod.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string memberNo = txtMemberNo.Text.Trim();
            if (string.IsNullOrEmpty(memberNo))
            {
                MessageBox.Show("请输入会员号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var bll = new huiyuan_bll();
                var dt = bll.SearchByNo(memberNo);
                
                if (dt != null && dt.Rows.Count > 0)
                {
                    _memberId = Convert.ToInt32(dt.Rows[0]["会员ID"]);
                    txtMemberName.Text = dt.Rows[0]["姓名"].ToString();
                    txtCurrentBalance.Text = Convert.ToDecimal(dt.Rows[0]["余额"]).ToString("F2");
                }
                else
                {
                    MessageBox.Show("未找到该会员", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMemberName.Text = "";
                    txtCurrentBalance.Text = "";
                    _memberId = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuickAmount_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                string text = btn.Text.Replace("元", "");
                txtAmount.Text = text + ".00";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_memberId == 0)
            {
                MessageBox.Show("请先查询会员信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("请输入有效的充值金额", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPayMethod.SelectedIndex < 0)
            {
                MessageBox.Show("请选择支付方式", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var result = MessageBox.Show(
                    $"确认为会员 {txtMemberName.Text} 充值 ￥{amount:F2} 吗？",
                    "确认充值",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var bll = new huiyuan_bll();
                    bll.Recharge(_memberId, amount, cmbPayMethod.Text);
                    
                    MessageBox.Show("充值成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // 刷新余额
                    decimal currentBalance = decimal.Parse(txtCurrentBalance.Text);
                    txtCurrentBalance.Text = (currentBalance + amount).ToString("F2");
                    txtAmount.Text = "0.00";
                    
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("充值失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
