using System;

namespace YCloud.CreditReport.Py.Model
{
    /// <summary>
    /// 鹏元征信报告-企业主贷款企业基本信息
    /// </summary>
    public class PYCREDIT_CORPBASE
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
        /// 规范化后的企业名称
        /// </summary>
        public string CORPNAME { get; set; }

		/// <summary>
        /// 规范化后的组织机构代码
        /// </summary>
        public string ORGCODE { get; set; }

		/// <summary>
        /// 规范化后的工商注册号
        /// </summary>
        public string REGISTERNO { get; set; }

		/// <summary>
        /// 企业类型id，详见数据字典
        /// </summary>
        public string CORPTYPE { get; set; }

		/// <summary>
        /// 企业所属行业id，详见数据字典
        /// </summary>
        public string TRADECODE { get; set; }

		/// <summary>
        /// 规范化后的法定代表人姓名
        /// </summary>
        public string ARTIFICIALNAME { get; set; }

		/// <summary>
        /// 规范化后的法定代表人证件号码
        /// </summary>
        public string ARTIFICIALNO { get; set; }

		/// <summary>
        /// 单位地址
        /// </summary>
        public string CORPADDRESS { get; set; }

		/// <summary>
        /// 单位电话，多个单位电话以英文逗号隔开。
        /// </summary>
        public string CORPTEL { get; set; }

		/// <summary>
        /// 信息获取日期，格式YYYYMMDD
        /// </summary>
        public DateTime? INFODATE { get; set; }
    }
}