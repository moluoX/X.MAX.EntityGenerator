using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace X.MAX.EntityGenerator.Common
{
    public class XPageModel : PageModel
    {
        public virtual ContentResult XJson(object m)
        {
            return Content(JsonConvert.SerializeObject(m), "application/json");
        }
    }
}
