﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLySanPham quanLySanPham = new QuanLySanPham();
            quanLySanPham.NhapDanhSachSP();
            quanLySanPham.InDanhSachSP();
            Console.ReadKey();
        }
    }
}
