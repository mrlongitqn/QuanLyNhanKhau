using QLNK.EF;
using QLNK.Repositories.Implements;
using QLNK.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace QLNK.Services
{
    public class DanhMucDuongService : DanhMucDuongRepository
    {
        private readonly DanhMucDuongRepository _danhMucDuongRepository;
        public DanhMucDuongService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _danhMucDuongRepository = new DanhMucDuongRepository(unitOfWork);
        }

        public List<DanhMucDuong> Search(string keyword)
        {
            return _danhMucDuongRepository.GetAll().Where(t => t.TenVietTat.Contains(keyword) || t.TenDayDu.Contains(keyword)).ToList();
        }

        public void SapXepThuTu(List<TinhTrangCuTru> tinhTrangCuTrus)
        {
            var stt = 1;
            foreach (var item in tinhTrangCuTrus)
            {
                item.STT = stt;
                stt++;
            }
        }
    }
}
