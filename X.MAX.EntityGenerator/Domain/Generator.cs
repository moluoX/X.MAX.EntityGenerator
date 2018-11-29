using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.MAX.EntityGenerator.Domain.Entity;

namespace X.MAX.EntityGenerator.Domain
{
    public class Generator
    {
        private readonly UserTableContext _context;
        private readonly IHostingEnvironment _env;

        public Generator(UserTableContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        private const string _zipName = "entityfilePack.zip";

        private string _savePath;
        public string SavePath
        {
            get
            {
                if (_savePath == null)
                {
                    _savePath = Path.Combine(_env.WebRootPath, "entityfile");
                }
                return _savePath;
            }
        }

        private string _classTemplate;
        public string ClassTemplate
        {
            get
            {
                if (_classTemplate == null)
                {
                    _classTemplate = File.ReadAllText(Path.Combine(_env.WebRootPath, "template/class.txt"));
                }
                return _classTemplate;
            }
        }

        private string _fieldTemplate;
        public string FieldTemplate
        {
            get
            {
                if (_fieldTemplate == null)
                {
                    _fieldTemplate = File.ReadAllText(Path.Combine(_env.WebRootPath, "template/field.txt"));
                }
                return _fieldTemplate;
            }
        }

        public IEnumerable<UserTable> ListTable(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return _context.UserTables;
            return _context.UserTables.Where(x => EF.Functions.Like(x.TABLE_NAME, s.ToUpper()));
        }
        
        public string Generate(string nspace, IList<string> tables)
        {
            if (Directory.Exists(SavePath))
                Directory.Delete(SavePath, true);
            Directory.CreateDirectory(SavePath);

            foreach (var table in tables)
            {
                GenerateOne(nspace, table);
            }

            //压缩
            var zipPath = Path.Combine(_env.WebRootPath, _zipName);
            if (File.Exists(zipPath))
                File.Delete(zipPath);
            ZipFile.CreateFromDirectory(SavePath, zipPath);

            return SavePath;
        }

        public void GenerateOne(string nspace, string table)
        {
            var columns = _context.UserTableColumns.Where(x => x.TABLE_NAME == table);
            if (!columns.Any()) return;
            var columnComments = _context.UserColumnComments.Where(x => x.TABLE_NAME == table).ToList();
            var tableComment = _context.UserTableComments.FirstOrDefault(x => x.TABLE_NAME == table)?.COMMENTS;

            StringBuilder sb = new StringBuilder();
            foreach (var column in columns)
            {
                var comment = columnComments.FirstOrDefault(x => x.COLUMN_NAME == column.COLUMN_NAME)?.COMMENTS;

                sb.AppendLine(FieldTemplate.Replace("{{comment}}", comment)
                    .Replace("{{name}}", column.COLUMN_NAME)
                    .Replace("{{type}}", GetFieldTypeString(column)))
                    .AppendLine();
            }

            var text = ClassTemplate.Replace("{{namespace}}", nspace)
                .Replace("{{comment}}", tableComment)
                .Replace("{{classname}}", table)
                .Replace("{{fields}}", sb.ToString().TrimEnd());

            File.WriteAllText(Path.Combine(SavePath, table + ".cs"), text);
        }

        private string GetFieldTypeString(UserTableColumn column)
        {
            var type = "";
            switch (column.DATA_TYPE)
            {
                case "BFILE":
                case "BLOB":
                case "LONG RAW":
                case "RAW":
                    type = "byte[]";
                    break;
                case "CHAR":
                case "CLOB":
                case "LONG":
                case "NCHAR":
                case "NCLOB":
                case "NVARCHAR2":
                case "ROWID":
                case "VARCHAR2":
                    type = "string";
                    break;
                case "DATE":
                case "TIMESTAMP":
                    type = "DateTime";
                    break;
                case "FLOAT":
                case "INTEGER":
                case "NUMBER":
                    type = "decimal";
                    break;
                case "INTERVAL YEAR TO  MONTH":
                    type = "int";
                    break;
                case "INTERVAL DAY TO  SECOND":
                    type = "TimeSpan";
                    break;
                default:
                    break;
            }

            if (column.NULLABLE == "Y" && type != "string")
                type += "?";
            return type;
        }
    }
}
