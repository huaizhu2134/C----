namespace C_大作业.UI
{
    partial class FrmShouYin
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
            this.pnlProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.pnlCartBottom = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.pnlMember = new System.Windows.Forms.Panel();
            this.cmbPayMethod = new System.Windows.Forms.ComboBox();
            this.btnCheckMember = new System.Windows.Forms.Button();
            this.txtMemberCard = new System.Windows.Forms.TextBox();
            this.lblMemberHint = new System.Windows.Forms.Label();
            this.lblCartTitle = new System.Windows.Forms.Label();
            this.pnlCart.SuspendLayout();
            this.pnlCartBottom.SuspendLayout();
            this.pnlMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProducts
            // 
            this.pnlProducts.AutoScroll = true;
            this.pnlProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProducts.Location = new System.Drawing.Point(0, 0);
            this.pnlProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.pnlProducts.Size = new System.Drawing.Size(930, 900);
            this.pnlProducts.TabIndex = 0;
            // 
            // pnlCart
            // 
            this.pnlCart.BackColor = System.Drawing.Color.White;
            this.pnlCart.Controls.Add(this.lstCart);
            this.pnlCart.Controls.Add(this.pnlCartBottom);
            this.pnlCart.Controls.Add(this.pnlMember);
            this.pnlCart.Controls.Add(this.lblCartTitle);
            this.pnlCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCart.Location = new System.Drawing.Point(930, 0);
            this.pnlCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Padding = new System.Windows.Forms.Padding(22, 22, 22, 22);
            this.pnlCart.Size = new System.Drawing.Size(570, 900);
            this.pnlCart.TabIndex = 1;
            // 
            // lstCart
            // 
            this.lstCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstCart.ItemHeight = 31;
            this.lstCart.Location = new System.Drawing.Point(22, 194);
            this.lstCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(526, 459);
            this.lstCart.TabIndex = 0;
            this.lstCart.DoubleClick += new System.EventHandler(this.lstCart_DoubleClick);
            // 
            // pnlCartBottom
            // 
            this.pnlCartBottom.Controls.Add(this.lblTotal);
            this.pnlCartBottom.Controls.Add(this.btnClear);
            this.pnlCartBottom.Controls.Add(this.btnCheckout);
            this.pnlCartBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCartBottom.Location = new System.Drawing.Point(22, 653);
            this.pnlCartBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCartBottom.Name = "pnlCartBottom";
            this.pnlCartBottom.Size = new System.Drawing.Size(526, 225);
            this.pnlCartBottom.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotal.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(526, 90);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "合计：￥0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(0, 60);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(526, 83);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCheckout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(0, 143);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(526, 82);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "结  账";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // pnlMember
            // 
            this.pnlMember.Controls.Add(this.cmbPayMethod);
            this.pnlMember.Controls.Add(this.btnCheckMember);
            this.pnlMember.Controls.Add(this.txtMemberCard);
            this.pnlMember.Controls.Add(this.lblMemberHint);
            this.pnlMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMember.Location = new System.Drawing.Point(22, 82);
            this.pnlMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMember.Name = "pnlMember";
            this.pnlMember.Size = new System.Drawing.Size(526, 112);
            this.pnlMember.TabIndex = 3;
            // 
            // cmbPayMethod
            // 
            this.cmbPayMethod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayMethod.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.cmbPayMethod.FormattingEnabled = true;
            this.cmbPayMethod.Items.AddRange(new object[] {
            "现金",
            "微信支付",
            "会员余额"});
            this.cmbPayMethod.Location = new System.Drawing.Point(0, 74);
            this.cmbPayMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPayMethod.Name = "cmbPayMethod";
            this.cmbPayMethod.Size = new System.Drawing.Size(346, 38);
            this.cmbPayMethod.TabIndex = 2;
            this.cmbPayMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPayMethod_SelectedIndexChanged);
            // 
            // btnCheckMember
            // 
            this.btnCheckMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnCheckMember.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCheckMember.FlatAppearance.BorderSize = 0;
            this.btnCheckMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckMember.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckMember.ForeColor = System.Drawing.Color.White;
            this.btnCheckMember.Location = new System.Drawing.Point(346, 69);
            this.btnCheckMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckMember.Name = "btnCheckMember";
            this.btnCheckMember.Size = new System.Drawing.Size(180, 43);
            this.btnCheckMember.TabIndex = 1;
            this.btnCheckMember.Text = "验证会员";
            this.btnCheckMember.UseVisualStyleBackColor = false;
            this.btnCheckMember.Click += new System.EventHandler(this.btnCheckMember_Click);
            // 
            // txtMemberCard
            // 
            this.txtMemberCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMemberCard.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.txtMemberCard.Location = new System.Drawing.Point(0, 32);
            this.txtMemberCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMemberCard.Name = "txtMemberCard";
            this.txtMemberCard.Size = new System.Drawing.Size(526, 37);
            this.txtMemberCard.TabIndex = 0;
            // 
            // lblMemberHint
            // 
            this.lblMemberHint.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMemberHint.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblMemberHint.ForeColor = System.Drawing.Color.Gray;
            this.lblMemberHint.Location = new System.Drawing.Point(0, 0);
            this.lblMemberHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberHint.Name = "lblMemberHint";
            this.lblMemberHint.Size = new System.Drawing.Size(526, 32);
            this.lblMemberHint.TabIndex = 3;
            this.lblMemberHint.Text = "会员卡号：";
            this.lblMemberHint.Click += new System.EventHandler(this.lblMemberHint_Click);
            // 
            // lblCartTitle
            // 
            this.lblCartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCartTitle.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCartTitle.Location = new System.Drawing.Point(22, 22);
            this.lblCartTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCartTitle.Name = "lblCartTitle";
            this.lblCartTitle.Size = new System.Drawing.Size(526, 60);
            this.lblCartTitle.TabIndex = 2;
            this.lblCartTitle.Text = "当前订单";
            // 
            // FrmShouYin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.pnlProducts);
            this.Controls.Add(this.pnlCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmShouYin";
            this.Text = "收银台";
            this.Load += new System.EventHandler(this.FrmShouYin_Load);
            this.pnlCart.ResumeLayout(false);
            this.pnlCartBottom.ResumeLayout(false);
            this.pnlMember.ResumeLayout(false);
            this.pnlMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlProducts;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Panel pnlCartBottom;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblCartTitle;
        private System.Windows.Forms.Panel pnlMember;
        private System.Windows.Forms.Label lblMemberHint;
        private System.Windows.Forms.TextBox txtMemberCard;
        private System.Windows.Forms.Button btnCheckMember;
        private System.Windows.Forms.ComboBox cmbPayMethod;
    }
}
