using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace FarmProduce
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
		private string _un;
		private string _pwd;
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
		/// <summary>
		/// 
		/// </summary>
		public string un
		{
			set{ _un=value;}
			get{return _un;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pwd
		{
			set{ _pwd=value;}
			get{return _pwd;}
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


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public t_user(Guid id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,name,sex,phone_no,QQ,email,address,un,pwd,type ");
			strSql.Append(" FROM [t_user] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					this.id=ds.Tables[0].Rows[0]["id"].ToString();
				if(ds.Tables[0].Rows[0]["name"]!=null)
				{
					this.name=ds.Tables[0].Rows[0]["name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sex"]!=null && ds.Tables[0].Rows[0]["sex"].ToString()!="")
				{
					this.sex=int.Parse(ds.Tables[0].Rows[0]["sex"].ToString());
				}
				if(ds.Tables[0].Rows[0]["phone_no"]!=null)
				{
					this.phone_no=ds.Tables[0].Rows[0]["phone_no"].ToString();
				}
				if(ds.Tables[0].Rows[0]["QQ"]!=null)
				{
					this.QQ=ds.Tables[0].Rows[0]["QQ"].ToString();
				}
				if(ds.Tables[0].Rows[0]["email"]!=null)
				{
					this.email=ds.Tables[0].Rows[0]["email"].ToString();
				}
				if(ds.Tables[0].Rows[0]["address"]!=null)
				{
					this.address=ds.Tables[0].Rows[0]["address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["un"]!=null)
				{
					this.un=ds.Tables[0].Rows[0]["un"].ToString();
				}
				if(ds.Tables[0].Rows[0]["pwd"]!=null)
				{
					this.pwd=ds.Tables[0].Rows[0]["pwd"].ToString();
				}
				if(ds.Tables[0].Rows[0]["type"]!=null && ds.Tables[0].Rows[0]["type"].ToString()!="")
				{
					this.type=int.Parse(ds.Tables[0].Rows[0]["type"].ToString());
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [t_user]");
			strSql.Append(" where id=@id ");

			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier)};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [t_user] (");
			strSql.Append("id,name,sex,phone_no,QQ,email,address,un,pwd,type)");
			strSql.Append(" values (");
			strSql.Append("@id,@name,@sex,@phone_no,@QQ,@email,@address,@un,@pwd,@type)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@sex", SqlDbType.Int,4),
					new SqlParameter("@phone_no", SqlDbType.NVarChar,50),
					new SqlParameter("@QQ", SqlDbType.NVarChar,50),
					new SqlParameter("@email", SqlDbType.NVarChar,50),
					new SqlParameter("@address", SqlDbType.NVarChar,200),
					new SqlParameter("@un", SqlDbType.NVarChar,50),
					new SqlParameter("@pwd", SqlDbType.NVarChar,50),
					new SqlParameter("@type", SqlDbType.Int,4)};
			parameters[0].Value = id;
			parameters[1].Value = name;
			parameters[2].Value = sex;
			parameters[3].Value = phone_no;
			parameters[4].Value = QQ;
			parameters[5].Value = email;
			parameters[6].Value = address;
			parameters[7].Value = un;
			parameters[8].Value = pwd;
			parameters[9].Value = type;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [t_user] set ");
			strSql.Append("name=@name,");
			strSql.Append("sex=@sex,");
			strSql.Append("phone_no=@phone_no,");
			strSql.Append("QQ=@QQ,");
			strSql.Append("email=@email,");
			strSql.Append("address=@address,");
			strSql.Append("un=@un,");
			strSql.Append("pwd=@pwd,");
			strSql.Append("type=@type");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@sex", SqlDbType.Int,4),
					new SqlParameter("@phone_no", SqlDbType.NVarChar,50),
					new SqlParameter("@QQ", SqlDbType.NVarChar,50),
					new SqlParameter("@email", SqlDbType.NVarChar,50),
					new SqlParameter("@address", SqlDbType.NVarChar,200),
					new SqlParameter("@un", SqlDbType.NVarChar,50),
					new SqlParameter("@pwd", SqlDbType.NVarChar,50),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = name;
			parameters[1].Value = sex;
			parameters[2].Value = phone_no;
			parameters[3].Value = QQ;
			parameters[4].Value = email;
			parameters[5].Value = address;
			parameters[6].Value = un;
			parameters[7].Value = pwd;
			parameters[8].Value = type;
			parameters[9].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from [t_user] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier)};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public void GetModel(Guid id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,name,sex,phone_no,QQ,email,address,un,pwd,type ");
			strSql.Append(" FROM [t_user] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.UniqueIdentifier)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					this.id=new Guid(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["name"]!=null )
				{
					this.name=ds.Tables[0].Rows[0]["name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sex"]!=null && ds.Tables[0].Rows[0]["sex"].ToString()!="")
				{
					this.sex=int.Parse(ds.Tables[0].Rows[0]["sex"].ToString());
				}
				if(ds.Tables[0].Rows[0]["phone_no"]!=null )
				{
					this.phone_no=ds.Tables[0].Rows[0]["phone_no"].ToString();
				}
				if(ds.Tables[0].Rows[0]["QQ"]!=null )
				{
					this.QQ=ds.Tables[0].Rows[0]["QQ"].ToString();
				}
				if(ds.Tables[0].Rows[0]["email"]!=null )
				{
					this.email=ds.Tables[0].Rows[0]["email"].ToString();
				}
				if(ds.Tables[0].Rows[0]["address"]!=null )
				{
					this.address=ds.Tables[0].Rows[0]["address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["un"]!=null )
				{
					this.un=ds.Tables[0].Rows[0]["un"].ToString();
				}
				if(ds.Tables[0].Rows[0]["pwd"]!=null )
				{
					this.pwd=ds.Tables[0].Rows[0]["pwd"].ToString();
				}
				if(ds.Tables[0].Rows[0]["type"]!=null && ds.Tables[0].Rows[0]["type"].ToString()!="")
				{
					this.type=int.Parse(ds.Tables[0].Rows[0]["type"].ToString());
				}
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM [t_user] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

