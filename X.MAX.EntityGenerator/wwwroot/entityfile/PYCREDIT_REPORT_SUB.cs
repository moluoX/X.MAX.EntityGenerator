using System;

namespace YCloud.CreditReport.Py.Model
{
    /// <summary>
    /// 鹏元征信报告-子报告
    /// </summary>
    public class PYCREDIT_REPORT_SUB
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
        /// 查询guid
        /// </summary>
        public string QUERYGUID { get; set; }

		/// <summary>
        /// 报告编号
        /// </summary>
        public string REPORTID { get; set; }

		/// <summary>
        /// 报告生成结束时间
        /// </summary>
        public DateTime? BUILDENDTIME { get; set; }

		/// <summary>
        /// 查询原因ID
        /// </summary>
        public string QUERYREASONID { get; set; }

		/// <summary>
        /// 查询的收费子报告ID,多个收费子报告ID用逗号分隔
        /// </summary>
        public string SUBREPORTTYPES { get; set; }

		/// <summary>
        /// 查询的收费子报告中文名称
        /// </summary>
        public string SUBREPORTTYPESSHORTCAPTION { get; set; }

		/// <summary>
        /// 对应的收费子报告收费次数,与subReportTypes一一对应,为大于等于0的值的集合,用逗号分隔
        /// </summary>
        public string TREATRESULT { get; set; }

		/// <summary>
        /// 引用ID,为查询申请条件中的引用ID
        /// </summary>
        public string REFID { get; set; }

		/// <summary>
        /// 有否系统错误，1：有错误，0：无错误
        /// </summary>
        public string HASSYSTEMERROR { get; set; }

		/// <summary>
        /// 该客户是否被冻结，1：被冻结，0：未被冻结
        /// </summary>
        public string ISFROZEN { get; set; }
    }
}