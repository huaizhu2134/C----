using System;
using System.Data;
using System.Data.Common;
using C_大作业.MODEL;

namespace C_大作业.DAL
{
    public class huiyuan_dal
    {
        public string Create(string shouji, string xingming)
        {
            var id = "M" + DateTime.Now.ToString("yyyyMMdd") + new Random().Next(100, 999).ToString();
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into huiyuan(huiyuan_id, shouji, xingming) values(@id,@shouji,@xingming)";
                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@id"; p1.Value = id; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@shouji"; p2.Value = shouji; cmd.Parameters.Add(p2);
                    var p3 = cmd.CreateParameter(); p3.ParameterName = "@xingming"; p3.Value = xingming; cmd.Parameters.Add(p3);
                    cmd.ExecuteNonQuery();
                }
            }
            return id;
        }

        public DataTable GetAllMembers()
        {
            var dt = new DataTable();
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select huiyuan_id as '会员卡号', shouji as '手机号', xingming as '姓名', yue as '余额', jifen as '积分' from huiyuan order by huiyuan_id desc";
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public DataTable SearchByPhone(string shouji)
        {
            var dt = new DataTable();
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select huiyuan_id as '会员卡号', shouji as '手机号', xingming as '姓名', yue as '余额', jifen as '积分' from huiyuan where shouji like @shouji";
                    var p = cmd.CreateParameter(); 
                    p.ParameterName = "@shouji"; 
                    p.Value = "%" + shouji + "%"; 
                    cmd.Parameters.Add(p);
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public void Chongzhi(string shouji, decimal amount)
        {
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update huiyuan set yue = yue + @amount, jifen = jifen + @jifen where shouji = @shouji";
                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@amount"; p1.Value = amount; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@jifen"; p2.Value = (int)amount; cmd.Parameters.Add(p2); // 充值1元送1积分
                    var p3 = cmd.CreateParameter(); p3.ParameterName = "@shouji"; p3.Value = shouji; cmd.Parameters.Add(p3);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable SearchByNo(string memberNo)
        {
            var dt = new DataTable();
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select huiyuan_id as '会员ID', huiyuan_id as '会员卡号', shouji as '手机号', xingming as '姓名', yue as '余额', jifen as '积分' from huiyuan where huiyuan_id = @no";
                    var p = cmd.CreateParameter();
                    p.ParameterName = "@no";
                    p.Value = memberNo;
                    cmd.Parameters.Add(p);
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public void Recharge(int memberId, decimal amount, string payMethod)
        {
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update huiyuan set yue = yue + @amount, jifen = jifen + @jifen where huiyuan_id = (select huiyuan_id from huiyuan where huiyuan_id like concat('%', @id, '%') limit 1)";
                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@amount"; p1.Value = amount; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@jifen"; p2.Value = (int)amount; cmd.Parameters.Add(p2);
                    var p3 = cmd.CreateParameter(); p3.ParameterName = "@id"; p3.Value = memberId.ToString(); cmd.Parameters.Add(p3);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
