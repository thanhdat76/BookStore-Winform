using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BookStoreManagement.Models
{
    class MRevenua
    {
        string _Thang;
        string _TraLuongNV;
        string _NhapSach;
        string _DoanhSoBanSach;
        string _LaiBanSach;
        string _ChoThueSach;

        public MRevenua(SqlDataReader rd)
        {
            this._Thang = rd["Thang"].ToString();
            this._TraLuongNV = rd["TraLuongNV"].ToString();
            this._NhapSach = rd["NhapSach"].ToString();
            this._DoanhSoBanSach = rd["DoanhSoBanSach"].ToString();
            this._LaiBanSach = rd["LaiBanSach"].ToString();
            this._ChoThueSach = rd["ChoThueSach"].ToString();
        }

        public MRevenua() { }

        public MRevenua(string thang, string traLuongNV, string nhapSach, string doanhSoBanSach, string laiBanSach, string choThueSach)
        {
            Thang = thang;
            TraLuongNV = traLuongNV;
            NhapSach = nhapSach;
            DoanhSoBanSach = doanhSoBanSach;
            LaiBanSach = laiBanSach;
            ChoThueSach = choThueSach;
        }


        public string Thang { get => _Thang; set => _Thang = value; }
        public string TraLuongNV { get => _TraLuongNV; set => _TraLuongNV = value; }
        public string NhapSach { get => _NhapSach; set => _NhapSach = value; }
        public string DoanhSoBanSach { get => _DoanhSoBanSach; set => _DoanhSoBanSach = value; }
        public string LaiBanSach { get => _LaiBanSach; set => _LaiBanSach = value; }
        public string ChoThueSach { get => _ChoThueSach; set => _ChoThueSach = value; }
    }
}
