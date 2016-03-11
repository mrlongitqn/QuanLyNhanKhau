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
   public class DanhMucKhuVucService : DanhMucKhuVucRepository
   {
       private readonly DanhMucKhuVucRepository _danhMucKhuvucRepository;
       public DanhMucKhuVucService(IUnitOfWork unitOfWork) : base(unitOfWork)
       {
           _danhMucKhuvucRepository = new DanhMucKhuVucRepository(unitOfWork);
       }

    }
}
