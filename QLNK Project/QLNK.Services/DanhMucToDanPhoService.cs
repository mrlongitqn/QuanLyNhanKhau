﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNK.EF;
using QLNK.Repositories.Implements;
using QLNK.Repositories.Interfaces;

namespace QLNK.Services
{
   public class DanhMucToDanPhoService : DanhMucToDanPhoRepository
   {
       private readonly DanhMucToDanPhoRepository _danhMucToDanPhoRepository;
       public DanhMucToDanPhoService(IUnitOfWork unitOfWork) : base(unitOfWork)
       {
           _danhMucToDanPhoRepository = new DanhMucToDanPhoRepository(unitOfWork);
       }

    }
}
