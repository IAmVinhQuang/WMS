using Prism.Commands;
using Prism.Regions;
using SimpleHmi.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleHmi.ViewModels
{
    class LeftMenuViewModel
    {
        public ICommand NavigateToMainPageCommand { get; private set; }
        public ICommand NavigateToDuLieuCoSoPageCommand { get; private set; }
        public ICommand NavigateToNhapKhoPageCommand { get; private set; }
        public ICommand NavigateToXuatKhoPageCommand { get; private set; }
        public ICommand NavigateToQuanLyKhachHangPageCommand { get; private set; }
        public ICommand NavigateToQuanLyNhaCCPageCommand { get; private set; }
        public ICommand NavigateToQuanLySPPageCommand { get; private set; }
        public ICommand NavigateToQuanLyTonKhoPageCommand { get; private set; }
        public ICommand NavigateToThongKePageCommand { get; private set; }
        public ICommand NavigateToViTriPageCommand { get; private set; }
        public ICommand NavigateToLoginWindowCommand { get; private set; }
     

        private readonly IRegionManager _regionManager;

        public LeftMenuViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateToMainPageCommand = new DelegateCommand(() => NavigateTo("MainPage"));
            NavigateToDuLieuCoSoPageCommand = new DelegateCommand(() => NavigateTo("DuLieuCoSoPage"));
            NavigateToNhapKhoPageCommand = new DelegateCommand(() => NavigateTo("NhapKhoPage"));
            NavigateToXuatKhoPageCommand = new DelegateCommand(() => NavigateTo("XuatKhoPage"));
            NavigateToQuanLyKhachHangPageCommand = new DelegateCommand(() => NavigateTo("QuanLyKhachHangPage"));
            NavigateToQuanLyNhaCCPageCommand = new DelegateCommand(() => NavigateTo("QuanLyNhaCCPage"));
            NavigateToQuanLySPPageCommand = new DelegateCommand(() => NavigateTo("QuanLySPPage"));
            NavigateToQuanLyTonKhoPageCommand = new DelegateCommand(() => NavigateTo("QuanLyTonKhoPage"));
            NavigateToThongKePageCommand = new DelegateCommand(() => NavigateTo("ThongKePage"));
            NavigateToLoginWindowCommand = new DelegateCommand(() => NavigateTo("LoginWindow"));
           
        }

        private void NavigateTo(string url)
        {
            _regionManager.RequestNavigate(Regions.ContentRegion, url);
        }
    }
}
