
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
   public class TinhTrangCuTruService : TinhTrangCuTruRepository
   {
       private readonly TinhTrangCuTruRepository _tinhTrangCuTruRepository;
       public TinhTrangCuTruService(IUnitOfWork unitOfWork) : base(unitOfWork)
       {
           _tinhTrangCuTruRepository = new TinhTrangCuTruRepository(unitOfWork);
       }

    }
}
