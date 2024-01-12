using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1
{
    internal class NuocUong : SanPham
    {
        private double loiNhuan;
        private double chiPhiGiuLanh;
        public NuocUong()
        {
            this.loiNhuan = this.GiaMua * 0.15;
            this.chiPhiGiuLanh = this.GiaMua * 0.1;
        }
        public NuocUong(string ten, double giaMua)
            : base(ten, giaMua)
        {
            this.loiNhuan = this.GiaMua * 0.15;
            this.chiPhiGiuLanh = this.GiaMua * 0.1;
        }
        public override double TinhGiaBan()
        {
            return this.GiaMua + this.loiNhuan + this.chiPhiGiuLanh;
        }
        public override void InChiTiet()
        {
            base.InChiTiet();
            Console.WriteLine("loi nhuan: {0}", this.loiNhuan);
            Console.WriteLine("chi phi giu lanh: {0}", this.chiPhiGiuLanh);
        }
        public override void Nhap()
        {
            base.Nhap();
        }
    }
}
