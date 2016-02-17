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
   public class CauHinhNguoiDungService : NguoiDungRepository
   {
       private readonly NguoiDungRepository _nguoiDungRepository;
       public CauHinhNguoiDungService(IUnitOfWork unitOfWork) : base(unitOfWork)
       {
           _nguoiDungRepository = new NguoiDungRepository(unitOfWork);
       }

       public void SapXepThuTu(List<NguoiDung> nguoiDungs)
       {
           var stt = 1;
           foreach (var item in nguoiDungs)
           {
               item.SoThuTu = stt;
               stt++;
           }
       }
    }
}
