﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ba_DemoAPI.EF
{
    public class Nhanvien
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string Manv { get; set; }
        public string  Diachi { get; set; }
        public string Gioitinh { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Phong { get; set; }
    }
}
