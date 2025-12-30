using System;
using System.Data;
using System.Data.Common;
using C_大作业.MODEL;

namespace C_大作业.DAL
{
    public class yonghu_dal
    {
        public yonghu GetByMingAndMima(string yonghu_ming, string mima)
        {
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                var sql = "select yonghu_id,yonghu_ming,mima_hash,juese,zhenshi_name,dianpu_id from yonghu where yonghu_ming=@ming and mima_hash=@mima limit 1";
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@ming"; p1.Value = yonghu_ming; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@mima"; p2.Value = mima; cmd.Parameters.Add(p2);

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            return new yonghu
                            {
                                yonghu_id = Convert.ToInt32(rdr["yonghu_id"]),
                                yonghu_ming = rdr["yonghu_ming"].ToString(),
                                mima_hash = rdr["mima_hash"] == DBNull.Value ? null : rdr["mima_hash"].ToString(),
                                juese = rdr["juese"] == DBNull.Value ? null : rdr["juese"].ToString(),
                                zhenshi_name = rdr["zhenshi_name"] == DBNull.Value ? null : rdr["zhenshi_name"].ToString(),
                                dianpu_id = rdr["dianpu_id"] == DBNull.Value ? 0 : Convert.ToInt32(rdr["dianpu_id"]) 
                            };
                        }
                    }
                }
            }
            return null;
        }

        public DataTable GetAllUsers()
        {
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                var sql = "select yonghu_id as '编号', yonghu_ming as '账号', zhenshi_name as '姓名', juese as '角色' from yonghu";
                var dt = new DataTable();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    using (var adapter = new MySql.Data.MySqlClient.MySqlDataAdapter((MySql.Data.MySqlClient.MySqlCommand)cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataTable SearchUsers(string keyword)
        {
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                var sql = "select yonghu_id as '编号', yonghu_ming as '账号', zhenshi_name as '姓名', juese as '角色' from yonghu where yonghu_ming like @keyword or zhenshi_name like @keyword";
                var dt = new DataTable();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    var p = cmd.CreateParameter();
                    p.ParameterName = "@keyword";
                    p.Value = "%" + keyword + "%";
                    cmd.Parameters.Add(p);
                    using (var adapter = new MySql.Data.MySqlClient.MySqlDataAdapter((MySql.Data.MySqlClient.MySqlCommand)cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public void AddUser(string username, string password, string realname)
        {
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                var sql = "insert into yonghu(yonghu_ming, mima_hash, zhenshi_name, juese, dianpu_id) values(@ming, @mima, @name, '收银员', 1)";
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@ming"; p1.Value = username; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@mima"; p2.Value = password; cmd.Parameters.Add(p2);
                    var p3 = cmd.CreateParameter(); p3.ParameterName = "@name"; p3.Value = realname; cmd.Parameters.Add(p3);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
