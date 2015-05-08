using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDb
{
	public class TaskEntity
	{
		public string Name { get; set; }

		public DateTime DateStart { get; set; }
		public int Number_obr { get; set; }

		public int Number_zayavki { get; set; }

		public string status { get; set; }

	}
}
