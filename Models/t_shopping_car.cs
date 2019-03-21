using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace FarmProduce
{
	/// <summary>
	/// 类t_shopping_car。
	/// </summary>
	[Serializable]
	public partial class t_shopping_car
	{
		public t_shopping_car()
		{}
		#region Model
		private Guid _id;
		private string _product_name;
		private Guid _product_id;
		private int? _count;
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
		public string product_name
		{
			set{ _product_name=value;}
			get{return _product_name;}
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
		public int? count
		{
			set{ _count=value;}
			get{return _count;}
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

