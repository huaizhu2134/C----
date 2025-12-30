using System;

namespace C_大作业.MODEL
{
    public class chanye
    {
        public int chanye_id { get; set; }
        public string chanye_name { get; set; }
        public decimal danjia { get; set; }
        public string fenlei { get; set; }
        public bool zhuangtai { get; set; }

        public override string ToString()
        {
            return chanye_name;
        }
    }
}
