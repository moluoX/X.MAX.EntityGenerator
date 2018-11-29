using System;

namespace YCloud.CreditReport.Py.Model
{
    /// <summary>
    /// 鹏元征信报告-贷款申请信息
    /// </summary>
    public class PYCREDIT_LOANAPPLY
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
        /// 个人身份标识id，详见数据字典
        /// </summary>
        public string PERSONIDENTITY { get; set; }

		/// <summary>
        /// 产品种类id，详见数据字典
        /// </summary>
        public string PRODUCTTYPE { get; set; }

		/// <summary>
        /// 借款用途id，详见数据字典
        /// </summary>
        public string LOANPURPOSE { get; set; }

		/// <summary>
        /// 申请日期，格式YYYYMMDD
        /// </summary>
        public DateTime? APPLYDATE { get; set; }

		/// <summary>
        /// 申请金额，单位：已币种为准
        /// </summary>
        public decimal? APPLYAMOUNT { get; set; }

		/// <summary>
        /// 币种id，详见数据字典
        /// </summary>
        public string CURRENCYTYPE { get; set; }

		/// <summary>
        /// 申请还款期数
        /// </summary>
        public decimal? PERIODS { get; set; }

		/// <summary>
        /// 贷款申请结果，1：已取消；2：已拒绝；3：已发放。
        /// </summary>
        public string APPLYSTATUS { get; set; }

		/// <summary>
        /// 拒绝原因id，详见数据字典
        /// </summary>
        public string REFUSEREASON { get; set; }

		/// <summary>
        /// 产品种类描述
        /// </summary>
        public string PRODUCTTYPEDESC { get; set; }

		/// <summary>
        /// 拒绝原因描述
        /// </summary>
        public string REFUSEREASONDESC { get; set; }

		/// <summary>
        /// 借款用途描述
        /// </summary>
        public string LOANPURPOSEDESC { get; set; }
    }
}