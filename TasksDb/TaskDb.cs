using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using ServiceStack.OrmLite;

namespace TasksDb
{
	public class TaskDb
	{
		private IDbConnection db;

		public TaskDb(IDbConnection db)
		{
			this.db = "Server = 127.0.0.1; Database = gov_audit; Uid = root; Pwd = root4Diadoc".OpenDbConnection();
		}

		public IEnumerable<TaskEntity> GetTasks(DateTime fromDate, DateTime toDate, int limit)
		{
			db.Select<TaskEntity>(e => e.);
		}
	}
}