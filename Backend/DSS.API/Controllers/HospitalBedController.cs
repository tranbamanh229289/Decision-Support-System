﻿using DSS.Core.entity;
using DSS.Core.interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DSS.Core.enums.Enum;

namespace DSS.API.Controllers
{
    /// <summary>
    /// Khai báo đường dẫn
    /// Create by: TQHa (22/7/2021)
    /// </summary>
    [Route("v1/[controller]")]
    [ApiController]
    public class HospitalBedController : BaseController<HospitalBed>
    {
        #region fields
        IBaseService<HospitalBed> _baseService;
        #endregion

        #region constructor

        /// <summary>
        /// Khởi tạo đối tượng 
        /// crrate by: TQHa (27/7/2021)
        /// </summary>
        public HospitalBedController(IBaseService<HospitalBed> baseService) : base(baseService)
        {
            _baseService = baseService;

        }
        #endregion

        
    }
}
