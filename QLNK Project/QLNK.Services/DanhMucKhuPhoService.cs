using QLNK.EF;
using QLNK.Repositories.Implements;
using QLNK.Repositories.Interfaces;
using System.Collections.Generic;

namespace QLNK.Services
{
    public class DanhMucKhuPhoService : DanhMucKhuPhoRepository
    {
        private readonly DanhMucDuongRepository _danhMucDuongRepository;
        public DanhMucKhuPhoService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _danhMucDuongRepository = new DanhMucDuongRepository(unitOfWork);
        }
        public void SapXepThuTu(List<DanhMucKhuPho> danhMucKhuPhos)
        {
            var stt = 1;
            foreach (var item in danhMucKhuPhos)
            {
                item.STT = stt;
                stt++;
            }
        }
    }
}
