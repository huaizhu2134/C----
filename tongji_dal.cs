using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace C_大作业.DAL
{
    public class tongji_dal
    {
        /// <summary>
        /// 获取今日营业数据
        /// </summary>
        public DataRow GetTodayStats()
        {
            using (var conn = MysqlHelper.GetConn() as MySqlConnection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT dingdan_shu, xiaoliang, yingye_e FROM yingye_tongji WHERE riqi = CURDATE()";
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        adapter.Fill(dt);
                        return dt.Rows.Count > 0 ? dt.Rows[0] : null;
                    }
                }
            }
        }

        /// <summary>
        /// 获取历史营业记录（近7天）
        /// </summary>
        public DataTable GetHistoryStats()
        {
            var dt = new DataTable();
            using (var conn = MysqlHelper.GetConn() as MySqlConnection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT 
                        DATE_FORMAT(riqi, '%Y-%m-%d') as '日期', 
                        dingdan_shu as '订单数', 
                        xiaoliang as '销售量', 
                        CONCAT('￥', FORMAT(yingye_e, 2)) as '营业额'
                        FROM yingye_tongji 
                        WHERE riqi < CURDATE()
                        ORDER BY riqi DESC 
                        LIMIT 7";
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// 更新今日营业数据
        /// </summary>
        public void UpdateTodayStats(int orders, int sales, decimal amount)
        {
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO yingye_tongji(riqi, dingdan_shu, xiaoliang, yingye_e) 
                        VALUES(CURDATE(), @orders, @sales, @amount)
                        ON DUPLICATE KEY UPDATE 
                        dingdan_shu = dingdan_shu + @orders,
                        xiaoliang = xiaoliang + @sales,
                        yingye_e = yingye_e + @amount";
                    
                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@orders"; p1.Value = orders; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@sales"; p2.Value = sales; cmd.Parameters.Add(p2);
                    var p3 = cmd.CreateParameter(); p3.ParameterName = "@amount"; p3.Value = amount; cmd.Parameters.Add(p3);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
