using System;
using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace C_大作业.DAL
{
    public class kucun_dal
    {
        public DataTable GetWarning()
        {
            var dt = new DataTable();
            using (var conn = MysqlHelper.GetConn() as MySqlConnection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand() as MySqlCommand)
                {
                    cmd.CommandText = "select kucun_id as '库存ID', yuanliao_name as '原料名称', danwei as '单位', shuliang as '剩余数量', anquan_xian as '安全线' from kucun";
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public void BuHuo(decimal liang)
        {
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update kucun set shuliang = shuliang + @liang";
                    var p = cmd.CreateParameter(); p.ParameterName = "@liang"; p.Value = liang; cmd.Parameters.Add(p);
                    cmd.ExecuteNonQuery();
                }

                using (var cmd2 = conn.CreateCommand())
                {
                    cmd2.CommandText = "insert into kucun_rizhi(yuanliao_name, bianhua, zhuangtai, beizhu) select yuanliao_name, @liang, 'ruku', '一键补货' from kucun";
                    var p2 = cmd2.CreateParameter(); p2.ParameterName = "@liang"; p2.Value = liang; cmd2.Parameters.Add(p2);
                    cmd2.ExecuteNonQuery();
                }
            }
        }
    }
}
