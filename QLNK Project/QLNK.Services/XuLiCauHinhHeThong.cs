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
   public class XuLiCauHinhHeThong : CauHinhChungRepository
   {
       private readonly CauHinhChungRepository _cauHinhChungRepository;
       public XuLiCauHinhHeThong(IUnitOfWork unitOfWork) : base(unitOfWork)
       {
           _cauHinhChungRepository = new CauHinhChungRepository(unitOfWork);
       }

        public CauHinhChung GetByKey(string key)
        {
            return _cauHinhChungRepository.GetAll().SingleOrDefault(t => t.TuKhoa.Equals(key));
        }
    }
}
