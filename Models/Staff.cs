using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement.Models
{
    class Staff
    {
        string _MaNV;
        string _TenNV;
        string _GioiTinh;
        string _DiaChi;
        string _SDT;

        public Staff()
        { }

        public Staff(string maNV, string tenNV, string gioiTinh, string diaChi, string sDT)
        {
            MaNV = maNV;
            TenNV = tenNV;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SDT = sDT;
        }

        public Staff(SqlDataReader rd)
        {
            this._MaNV = rd["MaNV"].ToString();
            this._TenNV = rd["TenNV"].ToString();
            this._GioiTinh = rd["GioiTinh"].ToString();
            this._DiaChi = rd["DiaChi"].ToString();
            this._SDT = rd["SDT"].ToString();
        }

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string TenNV { get => _TenNV; set => _TenNV = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
    }
}
