using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using X.MAX.EntityGenerator.Common;
using X.MAX.EntityGenerator.Domain;

namespace X.MAX.EntityGenerator.Pages
{
    public class IndexModel : XPageModel
    {
        private Generator _generator { get; set; }
        private const string _zipName = "entityfilePack.zip";

        [TempData]
        public string S { get; set; }

        public IEnumerable<string> Tables { get; set; }

        public IndexModel(Generator generator)
        {
            _generator = generator;
        }

        public void OnGet(string s)
        {
            S = s;
            Tables = _generator.ListTable(s).Select(x => x.TABLE_NAME);
        }

        public IActionResult OnPost(string nspace, IList<string> tables)
        {
            if (tables == null || !tables.Any())
                return XJson(new { code = 1, msg = "请选择表" });
            var path = _generator.Generate(nspace, tables);
            return XJson(new { code = 0, data = path, zip = "/" + _zipName });
        }
    }
}
