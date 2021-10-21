using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement.Models
{
    class Book
    {
        int _MaSach;
        string _TenSach;
        string _TheLoai;
        string _TacGia;
        int _GiaNhap;
        int _GiaBan;


        public Book(SqlDataReader rd)
        {
            this._MaSach = (int)rd["MaSach"];
            this._TenSach = rd["TenSach"].ToString();
            this._TheLoai = rd["TheLoai"].ToString();
            this._TacGia = rd["TacGia"].ToString();
            this._GiaNhap = (int)rd["GiaNhap"];
            this._GiaBan = (int)rd["GiaBan"];

        }

        public Book() { }

        public Book(int maSach, string tenSach, string theLoai, string tacGia, int giaNhap, int giaBan)
        {
            MaSach = maSach;
            TenSach = tenSach;
            TheLoai = theLoai;
            TacGia = tacGia;
            GiaNhap = giaNhap;
            GiaBan = giaBan;
        }

        public int MaSach { get => _MaSach; set => _MaSach = value; }
        public string TenSach { get => _TenSach; set => _TenSach = value; }
        public string TheLoai { get => _TheLoai; set => _TheLoai = value; }
        public string TacGia { get => _TacGia; set => _TacGia = value; }
        public int GiaNhap { get => _GiaNhap; set => _GiaNhap = value; }
        public int GiaBan { get => _GiaBan; set => _GiaBan = value; }
    }
}
