using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace Models
{
	/// <summary>
	/// 类t_user。
	/// </summary>
	[Serializable]
	public partial class t_user
	{
		public t_user()
		{}
		#region Model
		private Guid _id;
		private string _name;
		private int? _sex;
		private string _phone_no;
		private string _qq;
		private string _email;
		private string _address;
        public string un { get; set; }
        public string pwd { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public Guid id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string phone_no
		{
			set{ _phone_no=value;}
			get{return _phone_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QQ
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		#endregion Model

	}
}

