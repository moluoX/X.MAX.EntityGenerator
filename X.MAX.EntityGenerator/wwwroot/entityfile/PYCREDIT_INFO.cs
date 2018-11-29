using System;

namespace YCloud.CreditReport.Py.Model
{
    /// <summary>
    /// 鹏元征信报告-信息
    /// </summary>
    public class PYCREDIT_INFO
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
        /// 类型
        /// </summary>
        public string TYPE { get; set; }

		/// <summary>
        /// 子报告guid
        /// </summary>
        public string REPORTSUBGUID { get; set; }

		/// <summary>
        /// 子报告ID
        /// </summary>
        public string SUBREPORTTYPE { get; set; }

		/// <summary>
        /// 收费子报告ID
        /// </summary>
        public string SUBREPORTTYPECOST { get; set; }

		/// <summary>
        /// 子报告查询状态,1：查得，2：未查得，3：其他原因未查得
        /// </summary>
        public string TREATRESULT { get; set; }

		/// <summary>
        /// treatResult=3时的错误代码,详见数据字典,treatResult!=3时,该属性不存在
        /// </summary>
        public string TREATERRORCODE { get; set; }

		/// <summary>
        /// treatResult=3时的错误描述信息,treatResult!=3时,该属性的值为空
        /// </summary>
        public string ERRORMESSAGE { get; set; }
    }
}