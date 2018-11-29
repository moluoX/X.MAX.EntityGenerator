using System;

namespace YCloud.CreditReport.Py.Model
{
    /// <summary>
    /// 鹏元征信报告-查询
    /// </summary>
    public class PYCREDIT_REPORT_QUERY
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
        /// 报告类型(0:小额信贷|1:反欺诈|2:企业电话|3:企业信用|4:企业风险)
        /// </summary>
        public string TYPE { get; set; }

		/// <summary>
        /// 报告guid
        /// </summary>
        public string REPORTGUID { get; set; }

		/// <summary>
        /// 查询批次号
        /// </summary>
        public string BATNO { get; set; }

		/// <summary>
        /// 查询单位名称
        /// </summary>
        public string UNITNAME { get; set; }

		/// <summary>
        /// 分支机构名称
        /// </summary>
        public string SUBORGAN { get; set; }

		/// <summary>
        /// 查询操作员登录名
        /// </summary>
        public string QUERYUSERID { get; set; }

		/// <summary>
        /// 查询请求数量
        /// </summary>
        public decimal? QUERYCOUNT { get; set; }

		/// <summary>
        /// 查询申请时间
        /// </summary>
        public DateTime? RECEIVETIME { get; set; }
    }
}