using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace FarmProduce
{
	/// <summary>
	/// 类t_products。
	/// </summary>
	[Serializable]
	public partial class t_products
	{
		public t_products()
		{}
		#region Model
		private Guid _id;
		private string _name;
		private string _source;
		private string _create_person;
		private Guid _create_person_id;
		private string _description;
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
		public string source
		{
			set{ _source=value;}
			get{return _source;}
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
		public string description
		{
			set{ _description=value;}
			get{return _description;}
		}
		#endregion Model


	}
}

