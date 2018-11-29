using System;

namespace YCloud.CreditReport.Py.Model
{
    /// <summary>
    /// 鹏元征信报告
    /// </summary>
    public class PYCREDIT_REPORT
    {
		/// <summary>
        /// 对应贷款GUID
        /// </summary>
        public string LOANGUID { get; set; }

		/// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CREATEDATE { get; set; }

		/// <summary>
        /// 主键，对应big_data GUID
        /// </summary>
        public string GUID { get; set; }
    }
}