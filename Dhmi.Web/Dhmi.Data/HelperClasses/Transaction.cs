///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 14 Mart 2016 Pazartesi 16:37:33
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using dhmi.DaoClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace dhmi.HelperClasses
{
	/// <summary>Specific implementation of the Transaction class. The constructor will take care of the creation of the physical transaction and the opening of the connection. The transaction object is ready to use as soon as the constructor succeeds.</summary>
	public partial class Transaction : TransactionBase
	{
		/// <summary>CTor. Will read the connection string from an external source. Opens connection, class</summary>
		/// <param name="transactionIsolationLevel">IsolationLevel to use in the transaction</param>
		/// <param name="name">The name of the transaction to use.</param>
		public Transaction(IsolationLevel transactionIsolationLevel, string name):base(transactionIsolationLevel, name)
		{
			Debug.WriteLine("test2");
		}
		
		/// <summary>CTor.</summary>
		/// <param name="transactionIsolationLevel">IsolationLevel to use in the transaction</param>
		/// <param name="name">The name of the transaction to use.</param>
		/// <param name="connectionString">Connection string to use in this transaction</param>
		public Transaction(IsolationLevel transactionIsolationLevel, string name, string connectionString):base(transactionIsolationLevel, name, connectionString)
        {
            Debug.WriteLine("test3");

        }

        /// <summary>Creates a new DbConnection instance which will be used by all elements using this ITransaction instance. Reads ConnectionString from .config file.</summary>
        /// <returns>new DbConnection instance</returns>
        protected override DbConnection CreateConnection()
		{
			Debug.WriteLine("test4");
			return new CommonDaoBase().CreateConnection();
		}

		/// <summary>Creates a new DbConnection instance which will be used by all elements using this ITransaction instance</summary>
		/// <param name="connectionStringToUse">Connection string to use</param>
		/// <returns>new DbConnection instance</returns>
		protected override DbConnection CreateConnection(string connectionStringToUse)
		{
			Debug.WriteLine("test5");
			return new CommonDaoBase().CreateConnection(connectionStringToUse);
		}

		#region Included Code

		#endregion
	}
}
