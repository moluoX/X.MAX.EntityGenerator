using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using X.MAX.EntityGenerator.Common;

namespace X.MAX.EntityGenerator.Pages
{
    public class IndexModel : XPageModel
    {
        [TempData]
        public string S { get; set; }

        public IList<string> Tables { get; set; }

        public void OnGet(string s)
        {
            S = s;
            Tables = new[] { "1", "2" };
        }

        public IActionResult OnPost(IList<string> tables)
        {
            return XJson(new { code = 0, data = @"E:\code\ycloud.task\4_Manager\YCLOUD.Start\bin\Debug" });
        }
    }
}
