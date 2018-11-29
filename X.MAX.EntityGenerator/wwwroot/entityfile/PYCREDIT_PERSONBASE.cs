using System;

namespace YCloud.CreditReport.Py.Model
{
    /// <summary>
    /// 鹏元征信报告-贷款申请人基本信息
    /// </summary>
    public class PYCREDIT_PERSONBASE
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
        /// 最高学历id，详见数据字典
        /// </summary>
        public string EDUCATIUONID { get; set; }

		/// <summary>
        /// 月收入，单位：人民币元
        /// </summary>
        public decimal? SALARY { get; set; }

		/// <summary>
        /// 婚姻状况id，详见数据字典
        /// </summary>
        public string MARRIAGESTATUSID { get; set; }

		/// <summary>
        /// 规范化后的配偶姓名
        /// </summary>
        public string SPOUSENAME { get; set; }

		/// <summary>
        /// 规范化后的配偶证件号码
        /// </summary>
        public string SPOUSEDOCUMENTNO { get; set; }

		/// <summary>
        /// 规范化后的工作单位
        /// </summary>
        public string EMPLOYER { get; set; }

		/// <summary>
        /// 企业类型id，详见数据字典
        /// </summary>
        public string CORPTYPE { get; set; }

		/// <summary>
        /// 工作性质id，详见数据字典
        /// </summary>
        public string WORKQUALITY { get; set; }

		/// <summary>
        /// 工作部门
        /// </summary>
        public string DEPARTMENT { get; set; }

		/// <summary>
        /// 工作岗位
        /// </summary>
        public string POST { get; set; }

		/// <summary>
        /// 职业id，详见数据字典
        /// </summary>
        public string OCCUPATION { get; set; }

		/// <summary>
        /// 工作年限，单位：年，最多一位小数。
        /// </summary>
        public decimal? WORKYEARS { get; set; }

		/// <summary>
        /// 单位电话，多个单位电话以英文逗号隔开。
        /// </summary>
        public string CORPTEL { get; set; }

		/// <summary>
        /// 单位地址
        /// </summary>
        public string CORPADDRESS { get; set; }

		/// <summary>
        /// 居住地址
        /// </summary>
        public string HABITATIONADDRESS { get; set; }

		/// <summary>
        /// 居住类型id，详见数据字典
        /// </summary>
        public string HABITATIONTYPE { get; set; }

		/// <summary>
        /// 居住时长，按月为单位计量。
        /// </summary>
        public decimal? HABITATIONTIME { get; set; }

		/// <summary>
        /// 手机号码，多个手机号码以英文逗号隔开。
        /// </summary>
        public string MOBILE { get; set; }

		/// <summary>
        /// 住宅电话，多个住宅电话以英文逗号隔开。
        /// </summary>
        public string TEL { get; set; }

		/// <summary>
        /// 信息获取日期，格式YYYYMMDD
        /// </summary>
        public DateTime? INFODATE { get; set; }

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