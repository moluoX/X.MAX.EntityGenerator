using System;

namespace YCloud.CreditReport.Py.Model
{
    /// <summary>
    /// 鹏元征信报告-最近12期贷款还款记录信息
    /// </summary>
    public class PYCREDIT_PERIODSPAYMENT
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
        /// 信息guid
        /// </summary>
        public string INFOGUID { get; set; }

		/// <summary>
        /// 申请流水号，如果查询单位与申请贷款单位不相同，则只显示申请流水号后四位，前面几位用****表示
        /// </summary>
        public string APPLYNO { get; set; }

		/// <summary>
        /// 期数
        /// </summary>
        public decimal? PERIOD { get; set; }

		/// <summary>
        /// 应还款日期，格式YYYYMMDD
        /// </summary>
        public DateTime? PLANRETURNDATE { get; set; }

		/// <summary>
        /// 状态id，详见数据字典
        /// </summary>
        public string STATUS { get; set; }
    }
}