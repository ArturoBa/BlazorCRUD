using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAPI.Models
{
	public class People
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string Answer { get; set; }
		public bool Answered { get; set; }
	}
}
