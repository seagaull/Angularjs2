using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AngularJS.Practice.Helper
{
    public class JsonController:Controller
    {
        protected new ActionResult Json(object data,JsonRequestBehavior behaviour = JsonRequestBehavior.DenyGet)
        {
            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(data,new JsonSerializerSettings
                {
                    ContractResolver =new CamelCasePropertyNamesContractResolver(),
                    
                    
                }),ContentType = "application/json"

            };
            return jsonResult;
        }

    }
}