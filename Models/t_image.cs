using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace FarmProduce
{
	/// <summary>
	/// 类t_image。
	/// </summary>
	[Serializable]
	public partial class t_image
	{
		public t_image()
		{}
		#region Model
		private Guid _id;
		private string _src;
		private Guid _product_id;
		private string _product_name;
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
		public string src
		{
			set{ _src=value;}
			get{return _src;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid product_id
		{
			set{ _product_id=value;}
			get{return _product_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string product_name
		{
			set{ _product_name=value;}
			get{return _product_name;}
		}
		#endregion Model


	}
}

