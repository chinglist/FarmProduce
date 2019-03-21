using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace FarmProduce
{
	/// <summary>
	/// 类t_logistics。
	/// </summary>
	[Serializable]
	public partial class t_logistics
	{
		public t_logistics()
		{}
		#region Model
		private Guid _id;
		private string _no;
		private string _data;
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
		public string no
		{
			set{ _no=value;}
			get{return _no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string data
		{
			set{ _data=value;}
			get{return _data;}
		}
		#endregion Model


	}
}

