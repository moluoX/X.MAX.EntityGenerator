using System;

namespace YCloud.CreditReport.Py.Model
{
    /// <summary>
    /// 鹏元征信报告-贷款最近期还款履行记录信息
    /// </summary>
    public class PYCREDIT_LOANPAYMENT
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
        /// 信息guid
        /// </summary>
        public string INFOGUID { get; set; }

		/// <summary>
        /// 申请流水号，如果查询单位与申请贷款单位不相同，则只显示申请流水号后四位，前面几位用****表示
        /// </summary>
        public string APPLYNO { get; set; }

		/// <summary>
        /// 最近还款期数
        /// </summary>
        public decimal? PERIOD { get; set; }

		/// <summary>
        /// 本期应还款金额，单位：以贷款基本信息的币种为准
        /// </summary>
        public decimal? PLANRETURNAMOUNT { get; set; }

		/// <summary>
        /// 本期应还款日期，格式YYYYMMDD
        /// </summary>
        public DateTime? PLANRETURNDATE { get; set; }

		/// <summary>
        /// 本期实际还款金额，单位：以贷款基本信息的币种为准
        /// </summary>
        public decimal? FACTRETURNAMOUNT { get; set; }

		/// <summary>
        /// 本期实际还款日期，格式YYYYMMDD
        /// </summary>
        public DateTime? FACTRETURNDATE { get; set; }

		/// <summary>
        /// 本期还款状态id，详见数据字典
        /// </summary>
        public string STATUS { get; set; }

		/// <summary>
        /// 贷款余额，单位：以贷款基本信息的币种为准
        /// </summary>
        public decimal? LOANBALANCE { get; set; }

		/// <summary>
        /// 剩余未还清期数
        /// </summary>
        public decimal? REMAINPERIODS { get; set; }

		/// <summary>
        /// 当前逾期金额，单位：以贷款基本信息的币种为准
        /// </summary>
        public decimal? OVERDUETOTALAMOUNT { get; set; }

		/// <summary>
        /// 信息获取日期，格式YYYYMMDD
        /// </summary>
        public DateTime? INFODATE { get; set; }

		/// <summary>
        /// 主键GUID
        /// </summary>
        public string GUID { get; set; }
    }
}