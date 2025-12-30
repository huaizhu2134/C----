using System;
using System.Data;
using System.Windows.Forms;
using C_大作业.BLL;

namespace C_大作业.UI
{
    public partial class FrmChanPin : Form
    {
        public FrmChanPin()
        {
            InitializeComponent();
        }

        private void FrmChanPin_Load(object sender, EventArgs e)
        {
            LoadChanPin();
        }

        private void LoadChanPin()
        {
            try
            {
                var bll = new chanye_bll();
                DataTable dt = bll.GetAllDataTable();
                dgvChanPin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载商品数据失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                if (string.IsNullOrEmpty(keyword))
                {
                    LoadChanPin();
                    return;
                }

                var bll = new chanye_bll();
                DataTable dt = bll.Search(keyword);
                dgvChanPin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("搜索失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 创建添加商品对话框
            using (var dlg = new FrmChanPinEdit(0))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    LoadChanPin();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvChanPin.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择要编辑的商品", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int chanpinId = Convert.ToInt32(dgvChanPin.SelectedRows[0].Cells["编号"].Value);
            
            using (var dlg = new FrmChanPinEdit(chanpinId))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    LoadChanPin();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvChanPin.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择要删除的商品", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("确定要删除选中的商品吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int chanpinId = Convert.ToInt32(dgvChanPin.SelectedRows[0].Cells["编号"].Value);
                    var bll = new chanye_bll();
                    bll.Delete(chanpinId);
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChanPin();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadChanPin();
        }
    }

    // 简单的商品编辑对话框类（内嵌）
    public class FrmChanPinEdit : Form
    {
        private TextBox txtName;
        private TextBox txtPrice;
        private ComboBox cmbCategory;
        private Button btnOK;
        private Button btnCancel;
        private int _chanpinId;

        public FrmChanPinEdit(int chanpinId)
        {
            _chanpinId = chanpinId;
            InitializeComponents();
            
            if (_chanpinId > 0)
            {
                LoadChanPinData();
            }
        }

        private void InitializeComponents()
        {
            this.Text = _chanpinId == 0 ? "新增商品" : "编辑商品";
            this.Size = new System.Drawing.Size(400, 250);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lblName = new Label { Text = "商品名称：", Location = new System.Drawing.Point(30, 30), AutoSize = true };
            txtName = new TextBox { Location = new System.Drawing.Point(120, 27), Width = 200 };

            Label lblPrice = new Label { Text = "商品价格：", Location = new System.Drawing.Point(30, 70), AutoSize = true };
            txtPrice = new TextBox { Location = new System.Drawing.Point(120, 67), Width = 200 };

            Label lblCategory = new Label { Text = "商品分类：", Location = new System.Drawing.Point(30, 110), AutoSize = true };
            cmbCategory = new ComboBox { Location = new System.Drawing.Point(120, 107), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            cmbCategory.Items.AddRange(new object[] { "奶茶", "果茶", "咖啡", "小食" });
            cmbCategory.SelectedIndex = 0;

            btnOK = new Button { Text = "确定", Location = new System.Drawing.Point(120, 160), Width = 80 };
            btnOK.Click += BtnOK_Click;

            btnCancel = new Button { Text = "取消", Location = new System.Drawing.Point(220, 160), Width = 80, DialogResult = DialogResult.Cancel };

            this.Controls.AddRange(new Control[] { lblName, txtName, lblPrice, txtPrice, lblCategory, cmbCategory, btnOK, btnCancel });
            this.AcceptButton = btnOK;
            this.CancelButton = btnCancel;
        }

        private void LoadChanPinData()
        {
            // 加载商品数据用于编辑
            try
            {
                var bll = new chanye_bll();
                var dt = bll.GetById(_chanpinId);
                if (dt != null && dt.Rows.Count > 0)
                {
                    txtName.Text = dt.Rows[0]["产品名"].ToString();
                    txtPrice.Text = dt.Rows[0]["价格"].ToString();
                    string category = dt.Rows[0]["分类"].ToString();
                    int idx = cmbCategory.FindString(category);
                    if (idx >= 0) cmbCategory.SelectedIndex = idx;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载商品数据失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("请输入商品名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("请输入有效的商品价格", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var bll = new chanye_bll();
                if (_chanpinId == 0)
                {
                    bll.Add(txtName.Text.Trim(), price, cmbCategory.Text);
                }
                else
                {
                    bll.Update(_chanpinId, txtName.Text.Trim(), price, cmbCategory.Text);
                }
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
