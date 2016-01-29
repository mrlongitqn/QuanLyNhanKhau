using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNK.EF;
using QLNK.Repositories.Interfaces;

namespace QLNK.Repositories.Implements
{
   public class DanhMucDuongRepository : BaseRepository<DanhMucDuong>, IDanhMucDuongRepository
    {
       public DanhMucDuongRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
       {
       }
    }
}
