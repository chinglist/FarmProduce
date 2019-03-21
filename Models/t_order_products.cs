using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace FarmProduce
{
	/// <summary>
	/// 类t_order_products。
	/// </summary>
	[Serializable]
	public partial class t_order_products
	{
		public t_order_products()
		{}
		#region Model
		private Guid _id;
		private string _product_name;
		private Guid _product_id;
		private int? _count;
		private decimal? _amount;
		private decimal? _price;
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
		public decimal? amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? price
		{
			set{ _price=value;}
			get{return _price;}
		}
		#endregion Model


	}
}

