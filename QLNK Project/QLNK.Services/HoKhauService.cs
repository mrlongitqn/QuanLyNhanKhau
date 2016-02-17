
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
   public class HoKhauService : HoKhauRepository
   {
       private readonly HoKhauRepository _hoKhauRepository;
       public HoKhauService(IUnitOfWork unitOfWork) : base(unitOfWork)
       {
           _hoKhauRepository = new HoKhauRepository(unitOfWork);
       }

    }
}
