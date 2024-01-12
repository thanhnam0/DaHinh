using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1
{
    internal class SanPham
    {
        private string ten;
        private double giaMua;
        public SanPham()
        {
        }
        public SanPham(string ten, double giaMua)
        {
            this.Ten = ten;
            this.GiaMua = giaMua;
        }
        public string Ten
        {
            get { return this.ten; }
            set
            {
                if (value == null || value.Length == 0)
                {
                    Console.WriteLine("ten san pham khong duoc bo trong");
                }
                this.ten = value;
            }
        }
        public double GiaMua
        {
            get { return this.giaMua; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("gia mua khong duoc nho hon 0");
                }
                this.giaMua = value;
            }
        }
        public virtual double TinhGiaBan()
        {
            return 0;
        }
        public virtual void InChiTiet()
        {
            Console.WriteLine("ten san pham: {0}", this.Ten);
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Moi ban nhap ten san pham: ");
            this.Ten = Console.ReadLine();

            Console.WriteLine("Moi ban nhap gia mua san pham: ");
            this.GiaMua =double.Parse(Console.ReadLine());
        }
    }
}
