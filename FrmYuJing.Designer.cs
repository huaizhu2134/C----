namespace C_大作业.UI
{
    partial class FrmYuJing
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
            this.dgvKuCun = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnBatchRestock = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuCun)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKuCun
            // 
            this.dgvKuCun.AllowUserToAddRows = false;
            this.dgvKuCun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKuCun.BackgroundColor = System.Drawing.Color.White;
            this.dgvKuCun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKuCun.ColumnHeadersHeight = 45;
            this.dgvKuCun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKuCun.Location = new System.Drawing.Point(0, 75);
            this.dgvKuCun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKuCun.Name = "dgvKuCun";
            this.dgvKuCun.ReadOnly = true;
            this.dgvKuCun.RowHeadersVisible = false;
            this.dgvKuCun.RowHeadersWidth = 62;
            this.dgvKuCun.RowTemplate.Height = 40;
            this.dgvKuCun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKuCun.Size = new System.Drawing.Size(1500, 735);
            this.dgvKuCun.TabIndex = 0;
            this.dgvKuCun.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvKuCun_DataBindingComplete);
            this.dgvKuCun.DoubleClick += new System.EventHandler(this.dgvKuCun_DoubleClick);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.btnBatchRestock);
            this.pnlBottom.Controls.Add(this.btnRefresh);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 810);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1500, 90);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnBatchRestock
            // 
            this.btnBatchRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBatchRestock.FlatAppearance.BorderSize = 0;
            this.btnBatchRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatchRestock.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBatchRestock.ForeColor = System.Drawing.Color.White;
            this.btnBatchRestock.Location = new System.Drawing.Point(240, 15);
            this.btnBatchRestock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBatchRestock.Name = "btnBatchRestock";
            this.btnBatchRestock.Size = new System.Drawing.Size(240, 60);
            this.btnBatchRestock.TabIndex = 1;
            this.btnBatchRestock.Text = "批量补货+1000";
            this.btnBatchRestock.UseVisualStyleBackColor = false;
            this.btnBatchRestock.Click += new System.EventHandler(this.btnBatchRestock_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(30, 15);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(180, 60);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblHint
            // 
            this.lblHint.BackColor = System.Drawing.Color.White;
            this.lblHint.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHint.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHint.ForeColor = System.Drawing.Color.Red;
            this.lblHint.Location = new System.Drawing.Point(0, 0);
            this.lblHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHint.Name = "lblHint";
            this.lblHint.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblHint.Size = new System.Drawing.Size(1500, 75);
            this.lblHint.TabIndex = 2;
            this.lblHint.Text = "双击库存记录进行单个原料补货";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmYuJing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.dgvKuCun);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmYuJing";
            this.Text = "库存管理";
            this.Load += new System.EventHandler(this.FrmYuJing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuCun)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKuCun;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnBatchRestock;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblHint;
    }
}
