﻿using System.Web.Mvc;
using Common;
using Service.IService;
using WebPage.Controllers;

namespace WebPage.Areas.SysManage.Controllers
{
    public class CodeAreaController : BaseController
    {
        ICodeAreaManage CodeAreaManage;
        public CodeAreaController(ICodeAreaManage CodeAreaManage)
        {
            this.CodeAreaManage = CodeAreaManage;
        }

        public ActionResult Prov()
        {
            JsonHelper jsonHelper = new JsonHelper
            {
                Status = "y",
                Msg = "Success"
            };
            jsonHelper.Data = JsonConverter.Serialize(this.CodeAreaManage.LoadListAll( p => p.LEVELS == 1), false);
            return Json(jsonHelper);
        }

        public ActionResult City(string id)
        {
            JsonHelper jsonHelper = new JsonHelper
            {
                Status = "y",
                Msg = "Success"
            };
            if (string.IsNullOrEmpty(id))
            {
                jsonHelper.Msg = "Error";
                jsonHelper.Status = "n";
            }
            else
            {
                jsonHelper.Data = JsonConverter.Serialize(this.CodeAreaManage.LoadListAll(p => p.LEVELS == 2 && p.PID == id), false);
            }
            return Json(jsonHelper);
        }

        public ActionResult Country(string id)
        {
            JsonHelper jsonHelper = new JsonHelper
            {
                Status = "y",
                Msg = "Success"
            };
            if (string.IsNullOrEmpty(id))
            {
                jsonHelper.Msg = "Error";
                jsonHelper.Status = "n";
            }
            else
            {
                jsonHelper.Data = JsonConverter.Serialize(this.CodeAreaManage.LoadListAll(p => p.LEVELS == 3 && p.PID == id), false);
            }
            return Json(jsonHelper);
        }
    }
}