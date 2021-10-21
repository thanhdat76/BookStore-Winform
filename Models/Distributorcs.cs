using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement.Models
{
    class Distributorcs
    {
        string _MaNPP;
        string _TenNPP;
        string _DiaChi;
        string _SDT;

        public Distributorcs()
        { }

        public Distributorcs(string maNPP, string tenNPP, string diaChi, string sDT)
        {
            MaNPP = maNPP;
            TenNPP = tenNPP;
            DiaChi = diaChi;
            SDT = sDT;
        }

        public Distributorcs(SqlDataReader rd)
        {
            this._MaNPP = rd["MaNPP"].ToString();
            this._TenNPP = rd["TenNPP"].ToString();
            this._DiaChi = rd["DiaChi"].ToString();
            this._SDT = rd["SDT"].ToString();
        }

        public string MaNPP { get => _MaNPP; set => _MaNPP = value; }
        public string TenNPP { get => _TenNPP; set => _TenNPP = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
    }
}
