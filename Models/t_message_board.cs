using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace FarmProduce
{
	/// <summary>
	/// 类t_message_board。
	/// </summary>
	[Serializable]
	public partial class t_message_board
	{
		public t_message_board()
		{}
		#region Model
		private Guid _id;
		private string _message;
		private string _create_person;
		private Guid _create_person_id;
		private DateTime? _create_date;
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
		/// <summary>
		/// 
		/// </summary>
		public string create_person
		{
			set{ _create_person=value;}
			get{return _create_person;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid create_person_id
		{
			set{ _create_person_id=value;}
			get{return _create_person_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? create_date
		{
			set{ _create_date=value;}
			get{return _create_date;}
		}
		#endregion Model


	}
}

