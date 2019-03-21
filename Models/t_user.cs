using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
	/// t_user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
    public partial class t_user
    {
        public t_user()
        { }
        #region Model
        private Guid _id;
        private string _name;
        private Guid? _specialty_id;
        private string _specialty_name;
        private string _header_photo;
        private int? _sex;
        private int? _grade;
        private string _contact;
        private string _number;
        private string _un;
        private string _pwd;
        private int? _type;
        public Guid? class_id { get; set; }
        public string class_name { get; set; }
        public int age { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid? specialty_id
        {
            set { _specialty_id = value; }
            get { return _specialty_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string specialty_name
        {
            set { _specialty_name = value; }
            get { return _specialty_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string header_photo
        {
            set { _header_photo = value; }
            get { return _header_photo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? grade
        {
            set { _grade = value; }
            get { return _grade; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string contact
        {
            set { _contact = value; }
            get { return _contact; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string number
        {
            set { _number = value; }
            get { return _number; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string un
        {
            set { _un = value; }
            get { return _un; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pwd
        {
            set { _pwd = value; }
            get { return _pwd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? type
        {
            set { _type = value; }
            get { return _type; }
        }
        #endregion Model

    }
}
