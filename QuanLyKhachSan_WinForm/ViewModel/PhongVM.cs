using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_WinForm.Models;

namespace QuanLyKhachSan_WinForm.ViewModel
{
    public class PhongVM : INotifyPropertyChanged
    {
        private PhongModel phongMD = new PhongModel();
        public string MaPhong
        {
            get { return phongMD.MaPhong; }
            set
            {
                phongMD.MaPhong = value;
                OnPropertyChanged(nameof(MaPhong));
            }
        }

        public int soPhong { 
            get { return phongMD.soPhong; }
            set
            {
                phongMD.soPhong = value;
                OnPropertyChanged(nameof(soPhong));
            }
        }

        public int maloaiPhong
        {
            get { return phongMD.maloaiPhong; }
            set
            {
                phongMD.maloaiPhong = value;
                OnPropertyChanged(nameof(maloaiPhong));
            }
        }

        public decimal donGia
        {
            get { return phongMD.donGia; }
            set
            {
                phongMD.donGia = value;
                OnPropertyChanged(nameof(donGia));
            }
        }
        public string trangThai
        {
            get { return phongMD.trangThai; }
            set
            {
                phongMD.trangThai = value;
                OnPropertyChanged(nameof(trangThai));
            }
        }
        public string mota
        {
            get { return phongMD.mota; }
            set
            {
                phongMD.mota = value;
                OnPropertyChanged(nameof(mota));
            }
        }

        public void saveDatabase()
        {
            PhongRepository phongRepo = new PhongRepository();
            phongRepo.addPhong(phongMD);
        }



        public event PropertyChangedEventHandler PropertyChanged;


        //Hàm hỗ trợ 
        protected void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
