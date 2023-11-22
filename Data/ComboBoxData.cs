using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Data
{
    public class ComboBoxData
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
        public List<string> SearchCar = new List<string>
        {
            "Tên xe",
            "Hãng xe",
            "Loại xe"
        };

        public List<string> SearchCustomer = new List<string>
        {
            "Tên khách hàng",
            "Số điện thoại",
            "CCCD"
        };

        public List<string> StatusCar = new List<string>
        {
            "Trống",
            "Đang cho thuê"
        };

        public List<string> StatusRent = new List<string>
        {
            "Đang thuê",
            "Đã thanh toán",
        };
    }
}
