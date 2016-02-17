
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
   public class NhanKhauService : NhanKhauRepository
   {
       private readonly NhanKhauRepository _nhanKhauRepository;
       public NhanKhauService(IUnitOfWork unitOfWork) : base(unitOfWork)
       {
           _nhanKhauRepository = new NhanKhauRepository(unitOfWork);
       }

    }
}
