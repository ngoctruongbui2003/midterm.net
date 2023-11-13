using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Data
{
    public class SubData
    {
        public List<string> Brands = new List<string>
        {
            "Toyota",
            "Chevrolet",
            "Ford",
            "Honda",
            "Hyundai",
            "Isuzu",
            "Suzuki",
            "Kia",
            "Mitsubishi",
            "Lexus",
            "Mazda",
            "Nissan",
            "Subaru",
            "Sangyong",
            "Land Rover",
        };
        public List<string> Fuels = new List<string>
        {
            "Xăng",
            "Dầu Diesel",
            "Điện",
        };
        public List<string> Categories = new List<string>
        {
            "4 chỗ (Mini)",
            "4 chỗ (Sedan)",
            "4 chỗ (Hatchback)",
            "5 chỗ (CUV Gầm cao)",
            "7 chỗ (CUV Gầm cao)",
            "7 chỗ (MPV Gầm thấp)",
            "Bán tải",
        };
    }
}
