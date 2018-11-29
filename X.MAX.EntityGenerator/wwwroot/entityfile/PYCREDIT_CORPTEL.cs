using System;

namespace YCloud.CreditReport.Py.Model
{
    /// <summary>
    /// 鹏元征信报告-企业电话信息
    /// </summary>
    public class PYCREDIT_CORPTEL
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
        /// 获取到内容的方式，1：电话反查，2：名称正查
        /// </summary>
        public string DATAFROM { get; set; }

		/// <summary>
        /// 企业名称
        /// </summary>
        public string CORPNAME { get; set; }

		/// <summary>
        /// 电话号码
        /// </summary>
        public string TEL { get; set; }

		/// <summary>
        /// 行政区划代码
        /// </summary>
        public string AREACODE { get; set; }

		/// <summary>
        /// 行政区划
        /// </summary>
        public string AREADESC { get; set; }

		/// <summary>
        /// 不含行政区划的地址
        /// </summary>
        public string ADDRESS { get; set; }

		/// <summary>
        /// 数据类型，该字段只有dataFrom为2时才有值 1：注册电话地址 2：非注册电话地址
        /// </summary>
        public string DATATYPE { get; set; }
    }
}