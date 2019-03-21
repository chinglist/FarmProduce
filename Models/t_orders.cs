using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace FarmProduce
{
	/// <summary>
	/// 类t_orders。
	/// </summary>
	[Serializable]
	public partial class t_orders
	{
		public t_orders()
		{}
		#region Model
		private Guid _id;
		private int? _state;
		private decimal? _amount;
		private DateTime? _create_date;
		private string _logistics;
		private string _create_person;
		private Guid _create_person_id;
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
		public int? state
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? create_date
		{
			set{ _create_date=value;}
			get{return _create_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string logistics
		{
			set{ _logistics=value;}
			get{return _logistics;}
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
		#endregion Model


	}
}

