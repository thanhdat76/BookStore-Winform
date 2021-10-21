using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookStoreManagement.Models
{
    class MClient
    {
        string _MaKH;
        string _TenKH;
        string _GioiTinh;
        string _SDT;

        public MClient()
        { }

        public MClient(string maKH, string tenKH, string gioiTinh, string sDT)
        {
            MaKH = maKH;
            TenKH = tenKH;
            GioiTinh = gioiTinh;
            SDT = sDT;
        }

        public MClient(SqlDataReader rd)
        {
            this._MaKH = rd["MaKH"].ToString();
            this._TenKH = rd["TenKH"].ToString();
            this._GioiTinh = rd["GioiTinh"].ToString();
            this._SDT = rd["SDT"].ToString();
        }

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
    }
}
