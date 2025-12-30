namespace C_大作业.UI
{
    partial class FrmTongJi
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
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlAmount = new System.Windows.Forms.Panel();
            this.lblAmountUnit = new System.Windows.Forms.Label();
            this.lblAmountValue = new System.Windows.Forms.Label();
            this.lblAmountTitle = new System.Windows.Forms.Label();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.lblSalesUnit = new System.Windows.Forms.Label();
            this.lblSalesValue = new System.Windows.Forms.Label();
            this.lblSalesTitle = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lblOrdersUnit = new System.Windows.Forms.Label();
            this.lblOrdersValue = new System.Windows.Forms.Label();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.lblDashTitle = new System.Windows.Forms.Label();
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.pnlDashboard.SuspendLayout();
            this.pnlAmount.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.White;
            this.pnlDashboard.Controls.Add(this.pnlAmount);
            this.pnlDashboard.Controls.Add(this.pnlSales);
            this.pnlDashboard.Controls.Add(this.pnlOrders);
            this.pnlDashboard.Controls.Add(this.lblDashTitle);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Padding = new System.Windows.Forms.Padding(30);
            this.pnlDashboard.Size = new System.Drawing.Size(1000, 200);
            this.pnlDashboard.TabIndex = 0;
            // 
            // pnlAmount
            // 
            this.pnlAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.pnlAmount.Controls.Add(this.lblAmountUnit);
            this.pnlAmount.Controls.Add(this.lblAmountValue);
            this.pnlAmount.Controls.Add(this.lblAmountTitle);
            this.pnlAmount.Location = new System.Drawing.Point(490, 60);
            this.pnlAmount.Name = "pnlAmount";
            this.pnlAmount.Size = new System.Drawing.Size(200, 120);
            this.pnlAmount.TabIndex = 3;
            // 
            // lblAmountUnit
            // 
            this.lblAmountUnit.AutoSize = true;
            this.lblAmountUnit.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAmountUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblAmountUnit.Location = new System.Drawing.Point(15, 90);
            this.lblAmountUnit.Name = "lblAmountUnit";
            this.lblAmountUnit.Size = new System.Drawing.Size(24, 20);
            this.lblAmountUnit.TabIndex = 2;
            this.lblAmountUnit.Text = "元";
            // 
            // lblAmountValue
            // 
            this.lblAmountValue.AutoSize = true;
            this.lblAmountValue.Font = new System.Drawing.Font("微软雅黑", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAmountValue.ForeColor = System.Drawing.Color.White;
            this.lblAmountValue.Location = new System.Drawing.Point(15, 45);
            this.lblAmountValue.Name = "lblAmountValue";
            this.lblAmountValue.Size = new System.Drawing.Size(82, 46);
            this.lblAmountValue.TabIndex = 1;
            this.lblAmountValue.Text = "0.00";
            // 
            // lblAmountTitle
            // 
            this.lblAmountTitle.AutoSize = true;
            this.lblAmountTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAmountTitle.ForeColor = System.Drawing.Color.White;
            this.lblAmountTitle.Location = new System.Drawing.Point(15, 15);
            this.lblAmountTitle.Name = "lblAmountTitle";
            this.lblAmountTitle.Size = new System.Drawing.Size(90, 21);
            this.lblAmountTitle.TabIndex = 0;
            this.lblAmountTitle.Text = "今日营业额";
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.pnlSales.Controls.Add(this.lblSalesUnit);
            this.pnlSales.Controls.Add(this.lblSalesValue);
            this.pnlSales.Controls.Add(this.lblSalesTitle);
            this.pnlSales.Location = new System.Drawing.Point(260, 60);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(200, 120);
            this.pnlSales.TabIndex = 2;
            // 
            // lblSalesUnit
            // 
            this.lblSalesUnit.AutoSize = true;
            this.lblSalesUnit.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSalesUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblSalesUnit.Location = new System.Drawing.Point(15, 90);
            this.lblSalesUnit.Name = "lblSalesUnit";
            this.lblSalesUnit.Size = new System.Drawing.Size(24, 20);
            this.lblSalesUnit.TabIndex = 2;
            this.lblSalesUnit.Text = "杯";
            // 
            // lblSalesValue
            // 
            this.lblSalesValue.AutoSize = true;
            this.lblSalesValue.Font = new System.Drawing.Font("微软雅黑", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSalesValue.ForeColor = System.Drawing.Color.White;
            this.lblSalesValue.Location = new System.Drawing.Point(15, 45);
            this.lblSalesValue.Name = "lblSalesValue";
            this.lblSalesValue.Size = new System.Drawing.Size(41, 46);
            this.lblSalesValue.TabIndex = 1;
            this.lblSalesValue.Text = "0";
            // 
            // lblSalesTitle
            // 
            this.lblSalesTitle.AutoSize = true;
            this.lblSalesTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSalesTitle.ForeColor = System.Drawing.Color.White;
            this.lblSalesTitle.Location = new System.Drawing.Point(15, 15);
            this.lblSalesTitle.Name = "lblSalesTitle";
            this.lblSalesTitle.Size = new System.Drawing.Size(74, 21);
            this.lblSalesTitle.TabIndex = 0;
            this.lblSalesTitle.Text = "今日销量";
            // 
            // pnlOrders
            // 
            this.pnlOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.pnlOrders.Controls.Add(this.lblOrdersUnit);
            this.pnlOrders.Controls.Add(this.lblOrdersValue);
            this.pnlOrders.Controls.Add(this.lblOrdersTitle);
            this.pnlOrders.Location = new System.Drawing.Point(30, 60);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(200, 120);
            this.pnlOrders.TabIndex = 1;
            // 
            // lblOrdersUnit
            // 
            this.lblOrdersUnit.AutoSize = true;
            this.lblOrdersUnit.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOrdersUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblOrdersUnit.Location = new System.Drawing.Point(15, 90);
            this.lblOrdersUnit.Name = "lblOrdersUnit";
            this.lblOrdersUnit.Size = new System.Drawing.Size(24, 20);
            this.lblOrdersUnit.TabIndex = 2;
            this.lblOrdersUnit.Text = "单";
            // 
            // lblOrdersValue
            // 
            this.lblOrdersValue.AutoSize = true;
            this.lblOrdersValue.Font = new System.Drawing.Font("微软雅黑", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOrdersValue.ForeColor = System.Drawing.Color.White;
            this.lblOrdersValue.Location = new System.Drawing.Point(15, 45);
            this.lblOrdersValue.Name = "lblOrdersValue";
            this.lblOrdersValue.Size = new System.Drawing.Size(41, 46);
            this.lblOrdersValue.TabIndex = 1;
            this.lblOrdersValue.Text = "0";
            // 
            // lblOrdersTitle
            // 
            this.lblOrdersTitle.AutoSize = true;
            this.lblOrdersTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOrdersTitle.ForeColor = System.Drawing.Color.White;
            this.lblOrdersTitle.Location = new System.Drawing.Point(15, 15);
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            this.lblOrdersTitle.Size = new System.Drawing.Size(74, 21);
            this.lblOrdersTitle.TabIndex = 0;
            this.lblOrdersTitle.Text = "今日订单";
            // 
            // lblDashTitle
            // 
            this.lblDashTitle.AutoSize = true;
            this.lblDashTitle.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDashTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDashTitle.Location = new System.Drawing.Point(30, 15);
            this.lblDashTitle.Name = "lblDashTitle";
            this.lblDashTitle.Size = new System.Drawing.Size(146, 30);
            this.lblDashTitle.TabIndex = 0;
            this.lblDashTitle.Text = "今日营业概况";
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.BackColor = System.Drawing.Color.White;
            this.lblHistoryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHistoryTitle.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblHistoryTitle.Location = new System.Drawing.Point(0, 200);
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Padding = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.lblHistoryTitle.Size = new System.Drawing.Size(1000, 50);
            this.lblHistoryTitle.TabIndex = 1;
            this.lblHistoryTitle.Text = "近7天营业记录";
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistory.ColumnHeadersHeight = 40;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(0, 250);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowTemplate.Height = 35;
            this.dgvHistory.Size = new System.Drawing.Size(1000, 350);
            this.dgvHistory.TabIndex = 2;
            // 
            // FrmTongJi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.lblHistoryTitle);
            this.Controls.Add(this.pnlDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTongJi";
            this.Text = "营业统计";
            this.Load += new System.EventHandler(this.FrmTongJi_Load);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlAmount.ResumeLayout(false);
            this.pnlAmount.PerformLayout();
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlAmount;
        private System.Windows.Forms.Label lblAmountUnit;
        private System.Windows.Forms.Label lblAmountValue;
        private System.Windows.Forms.Label lblAmountTitle;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Label lblSalesUnit;
        private System.Windows.Forms.Label lblSalesValue;
        private System.Windows.Forms.Label lblSalesTitle;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Label lblOrdersUnit;
        private System.Windows.Forms.Label lblOrdersValue;
        private System.Windows.Forms.Label lblOrdersTitle;
        private System.Windows.Forms.Label lblDashTitle;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.DataGridView dgvHistory;
    }
}
