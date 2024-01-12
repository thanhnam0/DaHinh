using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1
{
    internal class Socola : SanPham
    {
        private double loiNhuan;
        public Socola()
        {
            this.loiNhuan = this.GiaMua * 0.2;
        }
        public Socola(string ten, double giaMua)
            : base(ten, giaMua)
        {
            this.loiNhuan = this.GiaMua * 0.2;
        }
        public override double TinhGiaBan()
        {
            return this.GiaMua + this.loiNhuan;
        }
        public override void InChiTiet()
        {
            base.InChiTiet();
            Console.WriteLine("loi nhuan: {0}", this.loiNhuan);
        }
        public override void Nhap()
        {
            base.Nhap();
        }
    }
}
