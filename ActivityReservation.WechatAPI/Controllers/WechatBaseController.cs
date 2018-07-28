﻿using ActivityReservation.WechatAPI.Filters;
using ActivityReservation.WechatAPI.Helper;
using Microsoft.AspNetCore.Mvc;
using WeihanLi.Common.Helpers;
using WeihanLi.Common.Log;

namespace ActivityReservation.WechatAPI.Controllers
{
    [WechatRequestValid]
    [Area("Wechat")]
    public class WechatBaseController : Controller
    {
        /// <summary>
        /// logger
        /// </summary>
        protected static ILogHelper Logger = LogHelper.GetLogHelper(typeof(WechatBaseController));

        public ContentResult Wechat(WechatContext wechatContext)
        {
            return Content(wechatContext.GetResponse());
        }
    }
}
