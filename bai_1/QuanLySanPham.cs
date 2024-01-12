using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1
{
    internal class QuanLySanPham
    {
        private string tenCuaHang;
        private int soLuongSanPham;
        private SanPham[] danhSachSP;

        public QuanLySanPham()
        {
            this.tenCuaHang = "Cua Hang Ban Le";
            this.soLuongSanPham = 0;
            this.danhSachSP = new SanPham[this.soLuongSanPham];
        }
        public string TenCuaHang
        {
            get { return this.tenCuaHang; }
            set { this.tenCuaHang = value; }
        }

        public int SoLuongSanPham
        {
            get { return this.soLuongSanPham; }
            set { this.soLuongSanPham = value; }
        }
        public SanPham[] DanhSachSP
        {
            get { return this.danhSachSP; }
            set { this.danhSachSP = value; }
        }
        public void NhapDanhSachSP()
        {
            int Chon;
            do
            {
                Console.WriteLine("----------------------san pham-------------------- ");
                Console.WriteLine("\n 1. Moi Nhap san pham Socola");
                Console.WriteLine("\n 2. Moi Nhap san pham Nuoc uong");
                Console.WriteLine("\n 0. Thoat");
                Console.WriteLine("\n Moi Nhap lua chon");
                Chon = int.Parse(Console.ReadLine());
                switch (Chon)
                {
                    case 1:
                        this.NhapSanPham(new Socola());
                        break;
                    case 2:
                        this.NhapSanPham(new NuocUong());
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("lua chon khong ton tai!");
                        break;
                }
            }
            while (Chon < 3);
        }

        private void NhapSanPham(SanPham sp)
        {
            Console.Write("\t Moi Ban Nhap Ten San Pham:  ");
            sp.Ten = Console.ReadLine();
            Console.Write("\t Moi Ban Nhap Gia Mua San Pham:  ");
            sp.GiaMua = double.Parse(Console.ReadLine());          
        }
        public void InDanhSachSP()
        {
            for (int i = 0; i < this.soLuongSanPham; i++)
            {
                this.danhSachSP[i].InChiTiet();
            }
        }
    }
}
