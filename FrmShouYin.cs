using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using C_大作业.BLL;
using C_大作业.MODEL;

namespace C_大作业.UI
{
    public partial class FrmShouYin : Form
    {
        private List<CartItem> cartItems = new List<CartItem>();
        private string memberId = null;
        private decimal memberDiscount = 1.0m;

        public FrmShouYin()
        {
            InitializeComponent();
        }

        private void FrmShouYin_Load(object sender, EventArgs e)
        {
            LoadProducts();
            cmbPayMethod.SelectedIndex = 0;
        }

        private void LoadProducts()
        {
            try
            {
                var bll = new chanye_bll();
                var products = bll.GetAll();
                pnlProducts.Controls.Clear();

                foreach (var p in products)
                {
                    var card = new Panel
                    {
                        Width = 150,
                        Height = 100,
                        Margin = new Padding(8),
                        BackColor = Color.White,
                        Cursor = Cursors.Hand,
                        Tag = p
                    };

                    var lblName = new Label
                    {
                        Text = p.chanye_name,
                        Font = new Font("微软雅黑", 12F, FontStyle.Bold),
                        Dock = DockStyle.Top,
                        Height = 50,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    var lblPrice = new Label
                    {
                        Text = "￥" + p.danjia.ToString("0.00"),
                        Font = new Font("微软雅黑", 14F, FontStyle.Bold),
                        ForeColor = Color.FromArgb(200, 50, 50),
                        Dock = DockStyle.Bottom,
                        Height = 40,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    card.Controls.AddRange(new Control[] { lblName, lblPrice });

                    EventHandler addToCart = (s, ev) =>
                    {
                        var product = card.Tag as chanye;
                        if (product == null) return;
                        var existing = cartItems.FirstOrDefault(x => x.Product.chanye_id == product.chanye_id);
                        if (existing != null) existing.Quantity++;
                        else cartItems.Add(new CartItem { Product = product, Quantity = 1 });
                        RefreshCart();
                    };

                    card.Click += addToCart;
                    lblName.Click += addToCart;
                    lblPrice.Click += addToCart;

                    pnlProducts.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载商品失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshCart()
        {
            lstCart.Items.Clear();
            decimal subtotal = 0;
            foreach (var item in cartItems)
            {
                var line = item.Product.chanye_name + " x" + item.Quantity + "  ￥" + (item.Product.danjia * item.Quantity).ToString("0.00");
                lstCart.Items.Add(line);
                subtotal += item.Product.danjia * item.Quantity;
            }
            
            // 计算折扣后金额
            decimal total = subtotal * memberDiscount;
            
            if (memberDiscount < 1.0m)
            {
                lblTotal.Text = $"小计：￥{subtotal:F2}\n会员折扣：{memberDiscount * 10:F1}折\n合计：￥{total:F2}";
            }
            else
            {
                lblTotal.Text = "合计：￥" + total.ToString("0.00");
            }
        }

        private void btnCheckMember_Click(object sender, EventArgs e)
        {
            string cardNo = txtMemberCard.Text.Trim();
            if (string.IsNullOrEmpty(cardNo))
            {
                MessageBox.Show("请输入会员卡号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var bll = new huiyuan_bll();
                var dt = bll.SearchByNo(cardNo);
                
                if (dt != null && dt.Rows.Count > 0)
                {
                    memberId = dt.Rows[0]["会员ID"].ToString();
                    string memberName = dt.Rows[0]["姓名"].ToString();
                    decimal balance = Convert.ToDecimal(dt.Rows[0]["余额"]);
                    
                    // 假设会员享受95折
                    memberDiscount = 0.95m;
                    
                    MessageBox.Show($"会员验证成功！\n姓名：{memberName}\n余额：￥{balance:F2}\n享受95折优惠", 
                        "会员信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    RefreshCart();
                }
                else
                {
                    MessageBox.Show("未找到该会员", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    memberId = null;
                    memberDiscount = 1.0m;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("会员验证失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstCart_DoubleClick(object sender, EventArgs e)
        {
            if (lstCart.SelectedIndex >= 0 && lstCart.SelectedIndex < cartItems.Count)
            {
                var item = cartItems[lstCart.SelectedIndex];
                if (item.Quantity > 1) item.Quantity--;
                else cartItems.RemoveAt(lstCart.SelectedIndex);
                RefreshCart();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cartItems.Clear();
            txtMemberCard.Clear();
            memberId = null;
            memberDiscount = 1.0m;
            RefreshCart();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MessageBox.Show("购物车为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subtotal = cartItems.Sum(x => x.Product.danjia * x.Quantity);
            decimal total = subtotal * memberDiscount;
            int totalQty = cartItems.Sum(x => x.Quantity);
            
            string payMethod = cmbPayMethod.SelectedItem?.ToString() ?? "现金";
            
            string confirmMsg = $"订单明细：\n";
            foreach (var item in cartItems)
            {
                confirmMsg += $"{item.Product.chanye_name} x{item.Quantity} = ￥{(item.Product.danjia * item.Quantity):F2}\n";
            }
            confirmMsg += $"\n小计：￥{subtotal:F2}\n";
            if (memberDiscount < 1.0m)
            {
                confirmMsg += $"会员折扣：{memberDiscount * 10:F1}折\n";
            }
            confirmMsg += $"应收金额：￥{total:F2}\n";
            confirmMsg += $"支付方式：{payMethod}\n\n确认结账？";
            
            var result = MessageBox.Show(confirmMsg, "结账确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                try
                {
                    // 生成订单号
                    string orderId = "DD" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    
                    // 保存订单到数据库
                    SaveOrder(orderId, total, payMethod);
                    
                    // 更新统计数据
                    var tongji = new tongji_bll();
                    tongji.RecordSale(1, totalQty, total);
                    
                    MessageBox.Show($"结账成功！\n订单号：{orderId}\n金额：￥{total:F2}\n支付方式：{payMethod}", 
                        "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // 清空购物车
                    cartItems.Clear();
                    txtMemberCard.Clear();
                    memberId = null;
                    memberDiscount = 1.0m;
                    RefreshCart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("结账失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveOrder(string orderId, decimal total, string payMethod)
        {
            using (var conn = DAL.MysqlHelper.GetConn())
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 插入订单主表
                        string zhifuType = "xianjin";
                        if (payMethod == "微信支付") zhifuType = "weixin";
                        else if (payMethod == "会员余额") zhifuType = "yue";
                        
                        var cmd = conn.CreateCommand();
                        cmd.Transaction = trans;
                        cmd.CommandText = @"INSERT INTO dingdan(dingdan_id, dianpu_id, huiyuan_id, yingshou, shishou, zhifufangshi) 
                                          VALUES(@id, 1, @member, @total, @total, @pay)";
                        
                        var p1 = cmd.CreateParameter(); p1.ParameterName = "@id"; p1.Value = orderId; cmd.Parameters.Add(p1);
                        var p2 = cmd.CreateParameter(); p2.ParameterName = "@member"; p2.Value = (object)memberId ?? DBNull.Value; cmd.Parameters.Add(p2);
                        var p3 = cmd.CreateParameter(); p3.ParameterName = "@total"; p3.Value = total; cmd.Parameters.Add(p3);
                        var p4 = cmd.CreateParameter(); p4.ParameterName = "@pay"; p4.Value = zhifuType; cmd.Parameters.Add(p4);
                        cmd.ExecuteNonQuery();
                        
                        // 插入订单明细
                        foreach (var item in cartItems)
                        {
                            cmd = conn.CreateCommand();
                            cmd.Transaction = trans;
                            cmd.CommandText = @"INSERT INTO dingdan_mingxi(dingdan_id, chanye_id, shuliang, danjia) 
                                              VALUES(@oid, @pid, @qty, @price)";
                            
                            var p5 = cmd.CreateParameter(); p5.ParameterName = "@oid"; p5.Value = orderId; cmd.Parameters.Add(p5);
                            var p6 = cmd.CreateParameter(); p6.ParameterName = "@pid"; p6.Value = item.Product.chanye_id; cmd.Parameters.Add(p6);
                            var p7 = cmd.CreateParameter(); p7.ParameterName = "@qty"; p7.Value = item.Quantity; cmd.Parameters.Add(p7);
                            var p8 = cmd.CreateParameter(); p8.ParameterName = "@price"; p8.Value = item.Product.danjia; cmd.Parameters.Add(p8);
                            cmd.ExecuteNonQuery();
                        }
                        
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        private class CartItem
        {
            public chanye Product { get; set; }
            public int Quantity { get; set; }
        }

        private void cmbPayMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMemberHint_Click(object sender, EventArgs e)
        {

        }
    }
}
