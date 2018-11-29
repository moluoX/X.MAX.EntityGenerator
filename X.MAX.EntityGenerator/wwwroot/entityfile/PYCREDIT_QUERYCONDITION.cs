using System;

namespace YCloud.CreditReport.Py.Model
{
    /// <summary>
    /// 鹏元征信报告-查询条件
    /// </summary>
    public class PYCREDIT_QUERYCONDITION
    {
		/// <summary>
        /// 主键GUID
        /// </summary>
        public string GUID { get; set; }

		/// <summary>
        /// 对应贷款GUID
        /// </summary>
        public string LOANGUID { get; set; }

		/// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CREATEDATE { get; set; }

		/// <summary>
        /// 子报告guid
        /// </summary>
        public string REPORTSUBGUID { get; set; }

		/// <summary>
        /// 查询条件英文名称
        /// </summary>
        public string NAME { get; set; }

		/// <summary>
        /// 查询条件中文名称
        /// </summary>
        public string CAPTION { get; set; }

		/// <summary>
        /// 查询条件值
        /// </summary>
        public string VALUE { get; set; }
    }
}