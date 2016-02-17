using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNK.EF;
using QLNK.Repositories.Implements;
using QLNK.Repositories.Interfaces;

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
            return _danhMucDuongRepository.GetAll().Where(t=>t.TenVietTat.Contains(keyword) || t.TenDayDu.Contains(keyword)).ToList();
        }
    }
}
