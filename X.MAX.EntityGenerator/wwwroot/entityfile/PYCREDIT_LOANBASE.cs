using System;

namespace YCloud.CreditReport.Py.Model
{
    /// <summary>
    /// 鹏元征信报告-贷款基本信息
    /// </summary>
    public class PYCREDIT_LOANBASE
    {
		/// <summary>
        /// 申请流水号，如果查询单位与申请贷款单位不相同，则只显示申请流水号后四位，前面几位用****表示
        /// </summary>
        public string APPLYNO { get; set; }

		/// <summary>
        /// 个人身份标识id，详见数据字典
        /// </summary>
        public string PERSONIDENTITY { get; set; }

		/// <summary>
        /// 贷款金额，已币种为准
        /// </summary>
        public decimal? LOANAMOUNT { get; set; }

		/// <summary>
        /// 币种id，详见数据字典
        /// </summary>
        public string CURRENCYTYPE { get; set; }

		/// <summary>
        /// 产品种类id，详见数据字典
        /// </summary>
        public string PRODUCTTYPE { get; set; }

		/// <summary>
        /// 还款周期id，详见数据字典
        /// </summary>
        public string PAYMENTPLAN { get; set; }

		/// <summary>
        /// 还款方式id，详见数据字典
        /// </summary>
        public string PAYMENTMODE { get; set; }

		/// <summary>
        /// 每期应还款金额，单位：以币种为准，比如币种为人民币时，单位为元。
        /// </summary>
        public decimal? PERIODREPAYAMOUNT { get; set; }

		/// <summary>
        /// 贷款发放日期，格式YYYYMMDD
        /// </summary>
        public DateTime? ACCOUNTDATE { get; set; }

		/// <summary>
        /// 贷款到期日期，格式YYYYMMDD
        /// </summary>
        public DateTime? RETURNDATE { get; set; }

		/// <summary>
        /// 贷款状态id，详见数据字典
        /// </summary>
        public string STATUS { get; set; }

		/// <summary>
        /// 贷款月利率
        /// </summary>
        public decimal? LOANMONTHAPR { get; set; }

		/// <summary>
        /// 其他月费率
        /// </summary>
        public decimal? OTHERMONTHAPR { get; set; }

		/// <summary>
        /// 手续费率
        /// </summary>
        public decimal? PROCEDUREAPR { get; set; }

		/// <summary>
        /// 罚息利率
        /// </summary>
        public decimal? PENALIZEAPR { get; set; }

		/// <summary>
        /// 提前还款手续费率
        /// </summary>
        public decimal? ADVANCEPAYMENTAPR { get; set; }

		/// <summary>
        /// 延期还款手续费率
        /// </summary>
        public decimal? OVERDUEPAYMENTAPR { get; set; }

		/// <summary>
        /// 信息获取日期，格式YYYYMMDD
        /// </summary>
        public DateTime? INFODATE { get; set; }

		/// <summary>
        /// 产品种类描述
        /// </summary>
        public string PRODUCTTYPEDESC { get; set; }

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
    }
}