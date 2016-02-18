
using QLNK.EF;
using QLNK.Repositories.Implements;
using QLNK.Repositories.Interfaces;
using System.Collections.Generic;

namespace QLNK.Services
{
    public class TinhTrangNhaOService : TinhTrangNhaORepository
    {
        private readonly TinhTrangNhaORepository _tinhTrangNhaORepository;
        public TinhTrangNhaOService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _tinhTrangNhaORepository = new TinhTrangNhaORepository(unitOfWork);
        }

        public void SapXepThuTu(List<TinhTrangNhaO> tinhTrangNhaOs)
        {
            var stt = 1;
            foreach (var item in tinhTrangNhaOs)
            {
                item.SoThuTu = stt;
                stt++;
            }
        }
    }
}
