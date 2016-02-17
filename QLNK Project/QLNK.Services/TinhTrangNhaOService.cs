
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
   public class TinhTrangNhaOService : TinhTrangNhaORepository
   {
       private readonly TinhTrangNhaORepository _tinhTrangNhaORepository;
       public TinhTrangNhaOService(IUnitOfWork unitOfWork) : base(unitOfWork)
       {
           _tinhTrangNhaORepository = new TinhTrangNhaORepository(unitOfWork);
       }

    }
}
