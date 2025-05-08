using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_WinForm.Models;

namespace QuanLyKhachSan_WinForm.ViewModel
{
    internal class PhongVM : INotifyPropertyChanged
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
        public event PropertyChangedEventHandler PropertyChanged;


        //Hàm hỗ trợ 
        protected void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
