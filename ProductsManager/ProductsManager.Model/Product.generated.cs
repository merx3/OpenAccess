#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using ProductsManager.Model;

namespace ProductsManager.Model	
{
	public partial class Product
	{
		private int _id;
		public virtual int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		
		private string _name;
		public virtual string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		
		private decimal? _price;
		public virtual decimal? Price
		{
			get
			{
				return this._price;
			}
			set
			{
				this._price = value;
			}
		}
		
		private bool _isAvailable;
		public virtual bool IsAvailable
		{
			get
			{
				return this._isAvailable;
			}
			set
			{
				this._isAvailable = value;
			}
		}
		
		private int _categoryId;
		public virtual int CategoryId
		{
			get
			{
				return this._categoryId;
			}
			set
			{
				this._categoryId = value;
			}
		}
		
		private Category _category;
		public virtual Category Category
		{
			get
			{
				return this._category;
			}
			set
			{
				this._category = value;
			}
		}
		
	}
}
#pragma warning restore 1591
