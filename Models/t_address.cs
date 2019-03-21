using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace FarmProduce
{
	/// <summary>
	/// 类t_address。
	/// </summary>
	[Serializable]
	public partial class t_address
	{
		public t_address()
		{}
		#region Model
		private Guid _id;
		private string _sheng;
		private string _di;
		private string _xian;
		private string _address;
		private int? _type;
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
		public string sheng
		{
			set{ _sheng=value;}
			get{return _sheng;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string di
		{
			set{ _di=value;}
			get{return _di;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string xian
		{
			set{ _xian=value;}
			get{return _xian;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? type
		{
			set{ _type=value;}
			get{return _type;}
		}
		#endregion Model


	}
}

