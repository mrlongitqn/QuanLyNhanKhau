
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
   public class LoaiHoSoService : LoaiHoSoRepository
   {
       private readonly LoaiHoSoRepository _loaiHoSoRepository;
       public LoaiHoSoService(IUnitOfWork unitOfWork) : base(unitOfWork)
       {
           _loaiHoSoRepository = new LoaiHoSoRepository(unitOfWork);
       }

    }
}
