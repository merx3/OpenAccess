﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ContextGenerator.ttinclude code generation file.
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
using SpikeOA.Model;

namespace SpikeOA.Model	
{
	public partial class ProductsManagerSpike : OpenAccessContext, IProductsManagerSpikeUnitOfWork
	{
		private static string connectionStringName = @"ProductsManagerConnection";
			
		private static BackendConfiguration backend = GetBackendConfiguration();
				
		private static MetadataSource metadataSource = XmlMetadataSource.FromAssemblyResource("ProductsManagerModel.rlinq");
		
		public ProductsManagerSpike()
			:base(connectionStringName, backend, metadataSource)
		{ }
		
		public ProductsManagerSpike(string connection)
			:base(connection, backend, metadataSource)
		{ }
		
		public ProductsManagerSpike(BackendConfiguration backendConfiguration)
			:base(connectionStringName, backendConfiguration, metadataSource)
		{ }
			
		public ProductsManagerSpike(string connection, MetadataSource metadataSource)
			:base(connection, backend, metadataSource)
		{ }
		
		public ProductsManagerSpike(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
			:base(connection, backendConfiguration, metadataSource)
		{ }
			
		public IQueryable<Product> Products 
		{
			get
			{
				return this.GetAll<Product>();
			}
		}
		
		public IQueryable<Category> Categories 
		{
			get
			{
				return this.GetAll<Category>();
			}
		}
		
		public static BackendConfiguration GetBackendConfiguration()
		{
			BackendConfiguration backend = new BackendConfiguration();
			backend.Backend = "MsSql";
			backend.ProviderName = "System.Data.SqlClient";
			return backend;
		}
	}
	
	public interface IProductsManagerSpikeUnitOfWork : IUnitOfWork
	{
		IQueryable<Product> Products
		{
			get;
		}
		IQueryable<Category> Categories
		{
			get;
		}
	}
}
#pragma warning restore 1591
