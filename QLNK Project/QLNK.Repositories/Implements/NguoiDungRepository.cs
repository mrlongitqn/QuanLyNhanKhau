using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNK.EF;
using QLNK.Repositories.Interfaces;

namespace QLNK.Repositories.Implements
{
   public class NguoiDungRepository : BaseRepository<NguoiDung>, INguoiDungRepository
    {
       public NguoiDungRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
       {
       }
    }
}
