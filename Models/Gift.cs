using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookStoreManagement.Models
{
    class Gift
    {
        int _MaQT;
        string _TenQT;
        string _img;

        public Gift(SqlDataReader rd)
        {
            this._MaQT = (int)rd["MaQT"];
            this._TenQT = rd["TenQT"].ToString();
            this._img = rd["img"].ToString();
        }

        public Gift() { }

        public Gift(int maQT, string tenQT, string imga)
        {
            MaQT = maQT;
            TenQT = tenQT;
            img = imga;
        }

        public int MaQT { get => _MaQT; set => _MaQT = value; }
        public string TenQT { get => _TenQT; set => _TenQT = value; }
        public string img { get => _img; set => _img = value; }

    }
}
