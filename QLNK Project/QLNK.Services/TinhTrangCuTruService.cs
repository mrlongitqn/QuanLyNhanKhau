using QLNK.EF;
using QLNK.Repositories.Implements;
using QLNK.Repositories.Interfaces;
using System.Collections.Generic;

namespace QLNK.Services
{
    public class TinhTrangCuTruService : TinhTrangCuTruRepository
    {
        private readonly TinhTrangCuTruRepository _tinhTrangCuTruRepository;
        public TinhTrangCuTruService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _tinhTrangCuTruRepository = new TinhTrangCuTruRepository(unitOfWork);
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
