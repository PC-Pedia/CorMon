﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CorMon.Web.Api.Controllers
{
  
    public class StagingTestsController : BaseController
    {
        #region Fields



        #endregion

        #region Ctor

        public StagingTestsController()
        {

        }

        #endregion

        #region Public Methods




        /// <summary>
        /// use in ui tests
        /// </summary>
        [HttpGet]
        public string Check_App_Initialization()
        {
            return "OK" ;
        }



        



        #endregion

        #region  Private Methods




        #endregion

    }
}