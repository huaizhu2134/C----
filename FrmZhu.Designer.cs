namespace C_大作业.UI
{
    partial class FrmZhu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRiBao = new System.Windows.Forms.Button();
            this.btnDingDan = new System.Windows.Forms.Button();
            this.btnCaiGou = new System.Windows.Forms.Button();
            this.btnChanPin = new System.Windows.Forms.Button();
            this.btnYongHu = new System.Windows.Forms.Button();
            this.btnTongJi = new System.Windows.Forms.Button();
            this.btnKuCun = new System.Windows.Forms.Button();
            this.btnHuiYuan = new System.Windows.Forms.Button();
            this.btnShouYin = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Black;
            this.pnlHeader.Controls.Add(this.lblUser);
            this.pnlHeader.Controls.Add(this.lblLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1800, 90);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(1518, 36);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(123, 30);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "当前员工：";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(30, 18);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(155, 52);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "C#奶茶";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Black;
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnRiBao);
            this.pnlMenu.Controls.Add(this.btnDingDan);
            this.pnlMenu.Controls.Add(this.btnCaiGou);
            this.pnlMenu.Controls.Add(this.btnChanPin);
            this.pnlMenu.Controls.Add(this.btnYongHu);
            this.pnlMenu.Controls.Add(this.btnTongJi);
            this.pnlMenu.Controls.Add(this.btnKuCun);
            this.pnlMenu.Controls.Add(this.btnHuiYuan);
            this.pnlMenu.Controls.Add(this.btnShouYin);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 90);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 960);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 810);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(240, 90);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "退出系统";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRiBao
            // 
            this.btnRiBao.BackColor = System.Drawing.Color.Black;
            this.btnRiBao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRiBao.FlatAppearance.BorderSize = 0;
            this.btnRiBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiBao.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.btnRiBao.ForeColor = System.Drawing.Color.White;
            this.btnRiBao.Location = new System.Drawing.Point(0, 720);
            this.btnRiBao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRiBao.Name = "btnRiBao";
            this.btnRiBao.Size = new System.Drawing.Size(240, 90);
            this.btnRiBao.TabIndex = 9;
            this.btnRiBao.Text = "日报表";
            this.btnRiBao.UseVisualStyleBackColor = false;
            this.btnRiBao.Click += new System.EventHandler(this.btnRiBao_Click);
            // 
            // btnDingDan
            // 
            this.btnDingDan.BackColor = System.Drawing.Color.Black;
            this.btnDingDan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDingDan.FlatAppearance.BorderSize = 0;
            this.btnDingDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDingDan.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.btnDingDan.ForeColor = System.Drawing.Color.White;
            this.btnDingDan.Location = new System.Drawing.Point(0, 630);
            this.btnDingDan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDingDan.Name = "btnDingDan";
            this.btnDingDan.Size = new System.Drawing.Size(240, 90);
            this.btnDingDan.TabIndex = 8;
            this.btnDingDan.Text = "订单查询";
            this.btnDingDan.UseVisualStyleBackColor = false;
            this.btnDingDan.Click += new System.EventHandler(this.btnDingDan_Click);
            // 
            // btnCaiGou
            // 
            this.btnCaiGou.BackColor = System.Drawing.Color.Black;
            this.btnCaiGou.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaiGou.FlatAppearance.BorderSize = 0;
            this.btnCaiGou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaiGou.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.btnCaiGou.ForeColor = System.Drawing.Color.White;
            this.btnCaiGou.Location = new System.Drawing.Point(0, 540);
            this.btnCaiGou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCaiGou.Name = "btnCaiGou";
            this.btnCaiGou.Size = new System.Drawing.Size(240, 90);
            this.btnCaiGou.TabIndex = 7;
            this.btnCaiGou.Text = "采购入库";
            this.btnCaiGou.UseVisualStyleBackColor = false;
            this.btnCaiGou.Click += new System.EventHandler(this.btnCaiGou_Click);
            // 
            // btnChanPin
            // 
            this.btnChanPin.BackColor = System.Drawing.Color.Black;
            this.btnChanPin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChanPin.FlatAppearance.BorderSize = 0;
            this.btnChanPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChanPin.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.btnChanPin.ForeColor = System.Drawing.Color.White;
            this.btnChanPin.Location = new System.Drawing.Point(0, 450);
            this.btnChanPin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChanPin.Name = "btnChanPin";
            this.btnChanPin.Size = new System.Drawing.Size(240, 90);
            this.btnChanPin.TabIndex = 6;
            this.btnChanPin.Text = "商品管理";
            this.btnChanPin.UseVisualStyleBackColor = false;
            this.btnChanPin.Click += new System.EventHandler(this.btnChanPin_Click);
            // 
            // btnYongHu
            // 
            this.btnYongHu.BackColor = System.Drawing.Color.Black;
            this.btnYongHu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYongHu.FlatAppearance.BorderSize = 0;
            this.btnYongHu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYongHu.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.btnYongHu.ForeColor = System.Drawing.Color.White;
            this.btnYongHu.Location = new System.Drawing.Point(0, 360);
            this.btnYongHu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYongHu.Name = "btnYongHu";
            this.btnYongHu.Size = new System.Drawing.Size(240, 90);
            this.btnYongHu.TabIndex = 5;
            this.btnYongHu.Text = "用户管理";
            this.btnYongHu.UseVisualStyleBackColor = false;
            this.btnYongHu.Click += new System.EventHandler(this.btnYongHu_Click);
            // 
            // btnTongJi
            // 
            this.btnTongJi.BackColor = System.Drawing.Color.Black;
            this.btnTongJi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTongJi.FlatAppearance.BorderSize = 0;
            this.btnTongJi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongJi.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.btnTongJi.ForeColor = System.Drawing.Color.White;
            this.btnTongJi.Location = new System.Drawing.Point(0, 270);
            this.btnTongJi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTongJi.Name = "btnTongJi";
            this.btnTongJi.Size = new System.Drawing.Size(240, 90);
            this.btnTongJi.TabIndex = 3;
            this.btnTongJi.Text = "营业统计";
            this.btnTongJi.UseVisualStyleBackColor = false;
            this.btnTongJi.Click += new System.EventHandler(this.btnTongJi_Click);
            // 
            // btnKuCun
            // 
            this.btnKuCun.BackColor = System.Drawing.Color.Black;
            this.btnKuCun.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKuCun.FlatAppearance.BorderSize = 0;
            this.btnKuCun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKuCun.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.btnKuCun.ForeColor = System.Drawing.Color.White;
            this.btnKuCun.Location = new System.Drawing.Point(0, 180);
            this.btnKuCun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKuCun.Name = "btnKuCun";
            this.btnKuCun.Size = new System.Drawing.Size(240, 90);
            this.btnKuCun.TabIndex = 2;
            this.btnKuCun.Text = "库存管理";
            this.btnKuCun.UseVisualStyleBackColor = false;
            this.btnKuCun.Click += new System.EventHandler(this.btnKuCun_Click);
            // 
            // btnHuiYuan
            // 
            this.btnHuiYuan.BackColor = System.Drawing.Color.Black;
            this.btnHuiYuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHuiYuan.FlatAppearance.BorderSize = 0;
            this.btnHuiYuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuiYuan.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.btnHuiYuan.ForeColor = System.Drawing.Color.White;
            this.btnHuiYuan.Location = new System.Drawing.Point(0, 90);
            this.btnHuiYuan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuiYuan.Name = "btnHuiYuan";
            this.btnHuiYuan.Size = new System.Drawing.Size(240, 90);
            this.btnHuiYuan.TabIndex = 1;
            this.btnHuiYuan.Text = "会员管理";
            this.btnHuiYuan.UseVisualStyleBackColor = false;
            this.btnHuiYuan.Click += new System.EventHandler(this.btnHuiYuan_Click);
            // 
            // btnShouYin
            // 
            this.btnShouYin.BackColor = System.Drawing.Color.Black;
            this.btnShouYin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShouYin.FlatAppearance.BorderSize = 0;
            this.btnShouYin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShouYin.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.btnShouYin.ForeColor = System.Drawing.Color.White;
            this.btnShouYin.Location = new System.Drawing.Point(0, 0);
            this.btnShouYin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShouYin.Name = "btnShouYin";
            this.btnShouYin.Size = new System.Drawing.Size(240, 90);
            this.btnShouYin.TabIndex = 0;
            this.btnShouYin.Text = "收银台";
            this.btnShouYin.UseVisualStyleBackColor = false;
            this.btnShouYin.Click += new System.EventHandler(this.btnShouYin_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(240, 90);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(22, 22, 22, 22);
            this.pnlContent.Size = new System.Drawing.Size(1560, 960);
            this.pnlContent.TabIndex = 2;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // FrmZhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1050);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1789, 1022);
            this.Name = "FrmZhu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C#奶茶 - 收银管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmZhu_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRiBao;
        private System.Windows.Forms.Button btnDingDan;
        private System.Windows.Forms.Button btnCaiGou;
        private System.Windows.Forms.Button btnChanPin;
        private System.Windows.Forms.Button btnYongHu;
        private System.Windows.Forms.Button btnTongJi;
        private System.Windows.Forms.Button btnKuCun;
        private System.Windows.Forms.Button btnHuiYuan;
        private System.Windows.Forms.Button btnShouYin;
        private System.Windows.Forms.Panel pnlContent;
    }
}
