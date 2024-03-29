﻿using Com.Anqa.Service.Pos.Lib.Services.SalesDocService;
using Com.Danliris.Service.Inventory.Lib.Services;
using Com.Danliris.Service.Inventory.WebApi.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.Anqa.Service.Pos.WebApi.Controllers.v1.ReportControllers
{

    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/sales/omzet-per-day")]
    [Authorize]
    public class OmzetDailyReportController : Controller
    {
        protected IIdentityService IdentityService;
        protected readonly IValidateService ValidateService;
        //public readonly IServiceProvider serviceProvider;
        protected readonly ISalesDocService Service;
        protected readonly string ApiVersion;

        public OmzetDailyReportController(IIdentityService identityService, IValidateService validateService, ISalesDocService service)
        {
            //this.serviceProvider = serviceProvider;
            IdentityService = identityService;
            ValidateService = validateService;
            Service = service;
            ApiVersion = "1.0.0";
        }

        protected void VerifyUser()
        {
            IdentityService.Username = User.Claims.ToArray().SingleOrDefault(p => p.Type.Equals("username")).Value;
            IdentityService.Token = Request.Headers["Authorization"].FirstOrDefault().Replace("Bearer ", "");
            IdentityService.TimezoneOffset = Convert.ToInt32(Request.Headers["x-timezone-offset"]);
        }

        [HttpGet]
        public IActionResult Get(DateTimeOffset dateFrom, DateTimeOffset dateTo, int offset, int page = 1, int size = 25, string Order = "{}")
        {
            try
            {

                var data = Service.GetOmzetDailyReport(dateFrom, dateTo, offset, page, size, Order);


                return Ok(new
                {
                    apiVersion = ApiVersion,
                    data = data.Item1,
                    info = new { total = data.Item2 },
                    message = General.OK_MESSAGE,
                    statusCode = General.OK_STATUS_CODE
                });
            }
            catch (Exception e)
            {
                Dictionary<string, object> Result =
                    new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message)
                    .Fail();
                return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, Result);
            }

        }
    }
}
