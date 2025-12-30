using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using C_大作业.MODEL;

namespace C_大作业.DAL
{
    public class chanye_dal
    {
        public List<chanye> GetAll()
        {
            var list = new List<chanye>();
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select chanye_id,chanye_name,danjia,fenlei,zhuangtai from chanye where zhuangtai=1";
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            list.Add(new chanye
                            {
                                chanye_id = Convert.ToInt32(rdr["chanye_id"]),
                                chanye_name = rdr["chanye_name"].ToString(),
                                danjia = Convert.ToDecimal(rdr["danjia"]),
                                fenlei = rdr["fenlei"].ToString(),
                                zhuangtai = Convert.ToBoolean(rdr["zhuangtai"])
                            });
                        }
                    }
                }
            }
            return list;
        }

        public int GetCount()
        {
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select count(1) from chanye where zhuangtai=1";
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public DataTable GetAllDataTable()
        {
            var dt = new DataTable();
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select chanye_id as '编号', chanye_name as '产品名', danjia as '价格', fenlei as '分类' from chanye where zhuangtai=1";
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public DataTable Search(string keyword)
        {
            var dt = new DataTable();
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select chanye_id as '编号', chanye_name as '产品名', danjia as '价格', fenlei as '分类' from chanye where zhuangtai=1 and (chanye_name like @kw or fenlei like @kw)";
                    var p = cmd.CreateParameter();
                    p.ParameterName = "@kw";
                    p.Value = "%" + keyword + "%";
                    cmd.Parameters.Add(p);
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public DataTable GetById(int id)
        {
            var dt = new DataTable();
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select chanye_id as '编号', chanye_name as '产品名', danjia as '价格', fenlei as '分类' from chanye where chanye_id=@id";
                    var p = cmd.CreateParameter();
                    p.ParameterName = "@id";
                    p.Value = id;
                    cmd.Parameters.Add(p);
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public void Add(string name, decimal price, string category)
        {
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into chanye(chanye_name, danjia, fenlei, zhuangtai) values(@name, @price, @category, 1)";
                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@name"; p1.Value = name; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@price"; p2.Value = price; cmd.Parameters.Add(p2);
                    var p3 = cmd.CreateParameter(); p3.ParameterName = "@category"; p3.Value = category; cmd.Parameters.Add(p3);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(int id, string name, decimal price, string category)
        {
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update chanye set chanye_name=@name, danjia=@price, fenlei=@category where chanye_id=@id";
                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@id"; p1.Value = id; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@name"; p2.Value = name; cmd.Parameters.Add(p2);
                    var p3 = cmd.CreateParameter(); p3.ParameterName = "@price"; p3.Value = price; cmd.Parameters.Add(p3);
                    var p4 = cmd.CreateParameter(); p4.ParameterName = "@category"; p4.Value = category; cmd.Parameters.Add(p4);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var conn = MysqlHelper.GetConn())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update chanye set zhuangtai=0 where chanye_id=@id";
                    var p = cmd.CreateParameter();
                    p.ParameterName = "@id";
                    p.Value = id;
                    cmd.Parameters.Add(p);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
