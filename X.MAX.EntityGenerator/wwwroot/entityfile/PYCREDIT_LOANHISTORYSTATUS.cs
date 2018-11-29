using System;

namespace YCloud.CreditReport.Py.Model
{
    /// <summary>
    /// 鹏元征信报告-贷款状态历史变动记录信息
    /// </summary>
    public class PYCREDIT_LOANHISTORYSTATUS
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
        /// 贷款状态变动记录，格式：状态（状态变动日期）,例如:正常 (2010年5月5日)
        /// </summary>
        public string STATUS { get; set; }

		/// <summary>
        /// 逾期本金，单位：以贷款基本信息的币种为准
        /// </summary>
        public decimal? OVERDUEAMOUNT { get; set; }

		/// <summary>
        /// 逾期天数
        /// </summary>
        public decimal? OVERDUEDAYS { get; set; }

		/// <summary>
        /// 信息获取日期，格式YYYYMMDD
        /// </summary>
        public DateTime? INFODATE { get; set; }
    }
}