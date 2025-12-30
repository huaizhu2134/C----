using System.Drawing;
using System.Windows.Forms;

namespace C_大作业.UI
{
    partial class FrmHuiYuanChongZhi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMemberNo = new System.Windows.Forms.Label();
            this.txtMemberNo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.pnlQuickAmount = new System.Windows.Forms.Panel();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.lblPayMethod = new System.Windows.Forms.Label();
            this.cmbPayMethod = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlQuickAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.lblMemberNo);
            this.pnlMain.Controls.Add(this.txtMemberNo);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.lblMemberName);
            this.pnlMain.Controls.Add(this.txtMemberName);
            this.pnlMain.Controls.Add(this.lblCurrentBalance);
            this.pnlMain.Controls.Add(this.txtCurrentBalance);
            this.pnlMain.Controls.Add(this.lblAmount);
            this.pnlMain.Controls.Add(this.txtAmount);
            this.pnlMain.Controls.Add(this.pnlQuickAmount);
            this.pnlMain.Controls.Add(this.lblPayMethod);
            this.pnlMain.Controls.Add(this.cmbPayMethod);
            this.pnlMain.Controls.Add(this.btnConfirm);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(822, 825);
            this.pnlMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.lblTitle.Location = new System.Drawing.Point(270, 45);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "会员充值";
            // 
            // lblMemberNo
            // 
            this.lblMemberNo.AutoSize = true;
            this.lblMemberNo.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMemberNo.Location = new System.Drawing.Point(90, 135);
            this.lblMemberNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberNo.Name = "lblMemberNo";
            this.lblMemberNo.Size = new System.Drawing.Size(92, 27);
            this.lblMemberNo.TabIndex = 1;
            this.lblMemberNo.Text = "会员号：";
            // 
            // txtMemberNo
            // 
            this.txtMemberNo.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMemberNo.Location = new System.Drawing.Point(210, 130);
            this.txtMemberNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMemberNo.Name = "txtMemberNo";
            this.txtMemberNo.Size = new System.Drawing.Size(298, 34);
            this.txtMemberNo.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(540, 128);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 42);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMemberName.Location = new System.Drawing.Point(90, 210);
            this.lblMemberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(112, 27);
            this.lblMemberName.TabIndex = 4;
            this.lblMemberName.Text = "会员姓名：";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMemberName.Location = new System.Drawing.Point(210, 206);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(433, 34);
            this.txtMemberName.TabIndex = 5;
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentBalance.Location = new System.Drawing.Point(90, 285);
            this.lblCurrentBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(112, 27);
            this.lblCurrentBalance.TabIndex = 6;
            this.lblCurrentBalance.Text = "当前余额：";
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCurrentBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.txtCurrentBalance.Location = new System.Drawing.Point(210, 280);
            this.txtCurrentBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.ReadOnly = true;
            this.txtCurrentBalance.Size = new System.Drawing.Size(433, 34);
            this.txtCurrentBalance.TabIndex = 7;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAmount.Location = new System.Drawing.Point(90, 360);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(112, 27);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "充值金额：";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.txtAmount.Location = new System.Drawing.Point(210, 356);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(433, 39);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.Text = "0.00";
            // 
            // pnlQuickAmount
            // 
            this.pnlQuickAmount.Controls.Add(this.btn50);
            this.pnlQuickAmount.Controls.Add(this.btn100);
            this.pnlQuickAmount.Controls.Add(this.btn200);
            this.pnlQuickAmount.Controls.Add(this.btn500);
            this.pnlQuickAmount.Location = new System.Drawing.Point(90, 428);
            this.pnlQuickAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlQuickAmount.Name = "pnlQuickAmount";
            this.pnlQuickAmount.Size = new System.Drawing.Size(555, 120);
            this.pnlQuickAmount.TabIndex = 10;
            // 
            // btn50
            // 
            this.btn50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn50.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn50.Location = new System.Drawing.Point(15, 15);
            this.btn50.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(120, 90);
            this.btn50.TabIndex = 0;
            this.btn50.Text = "50元";
            this.btn50.UseVisualStyleBackColor = false;
            this.btn50.Click += new System.EventHandler(this.btnQuickAmount_Click);
            // 
            // btn100
            // 
            this.btn100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btn100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn100.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn100.Location = new System.Drawing.Point(143, 15);
            this.btn100.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(120, 90);
            this.btn100.TabIndex = 1;
            this.btn100.Text = "100元";
            this.btn100.UseVisualStyleBackColor = false;
            this.btn100.Click += new System.EventHandler(this.btnQuickAmount_Click);
            // 
            // btn200
            // 
            this.btn200.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btn200.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn200.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn200.Location = new System.Drawing.Point(271, 15);
            this.btn200.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(120, 90);
            this.btn200.TabIndex = 2;
            this.btn200.Text = "200元";
            this.btn200.UseVisualStyleBackColor = false;
            this.btn200.Click += new System.EventHandler(this.btnQuickAmount_Click);
            // 
            // btn500
            // 
            this.btn500.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btn500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn500.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn500.Location = new System.Drawing.Point(399, 15);
            this.btn500.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(120, 90);
            this.btn500.TabIndex = 3;
            this.btn500.Text = "500元";
            this.btn500.UseVisualStyleBackColor = false;
            this.btn500.Click += new System.EventHandler(this.btnQuickAmount_Click);
            // 
            // lblPayMethod
            // 
            this.lblPayMethod.AutoSize = true;
            this.lblPayMethod.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPayMethod.Location = new System.Drawing.Point(90, 585);
            this.lblPayMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayMethod.Name = "lblPayMethod";
            this.lblPayMethod.Size = new System.Drawing.Size(112, 27);
            this.lblPayMethod.TabIndex = 11;
            this.lblPayMethod.Text = "支付方式：";
            // 
            // cmbPayMethod
            // 
            this.cmbPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayMethod.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPayMethod.FormattingEnabled = true;
            this.cmbPayMethod.Items.AddRange(new object[] {
            "现金",
            "微信支付",
            "支付宝",
            "银行卡"});
            this.cmbPayMethod.Location = new System.Drawing.Point(210, 580);
            this.cmbPayMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPayMethod.Name = "cmbPayMethod";
            this.cmbPayMethod.Size = new System.Drawing.Size(433, 35);
            this.cmbPayMethod.TabIndex = 12;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(210, 690);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(180, 60);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "确认充值";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(420, 690);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 60);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmHuiYuanChongZhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 825);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHuiYuanChongZhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "会员充值";
            this.Load += new System.EventHandler(this.FrmHuiYuanChongZhi_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlQuickAmount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMemberNo;
        private System.Windows.Forms.TextBox txtMemberNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.TextBox txtCurrentBalance;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Panel pnlQuickAmount;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Label lblPayMethod;
        private System.Windows.Forms.ComboBox cmbPayMethod;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}
