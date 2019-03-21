using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace FarmProduce
{
	/// <summary>
	/// 类t_notice。
	/// </summary>
	[Serializable]
	public partial class t_notice
	{
		public t_notice()
		{}
		#region Model
		private Guid _id;
		private string _message;
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
		public string message
		{
			set{ _message=value;}
			get{return _message;}
		}
		#endregion Model


	}
}

