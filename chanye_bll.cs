using System;
using System.Collections.Generic;
using System.Data;
using C_大作业.MODEL;
using C_大作业.DAL;

namespace C_大作业.BLL
{
    public class chanye_bll
    {
        private readonly chanye_dal dal = new chanye_dal();

        public List<chanye> GetAll()
        {
            return dal.GetAll();
        }

        public int GetCount()
        {
            return dal.GetCount();
        }

        public DataTable GetAllDataTable()
        {
            return dal.GetAllDataTable();
        }

        public DataTable Search(string keyword)
        {
            return dal.Search(keyword);
        }

        public DataTable GetById(int id)
        {
            return dal.GetById(id);
        }

        public void Add(string name, decimal price, string category)
        {
            dal.Add(name, price, category);
        }

        public void Update(int id, string name, decimal price, string category)
        {
            dal.Update(id, name, price, category);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }
    }
}
