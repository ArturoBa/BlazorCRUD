using BlazorAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAPI.Contexts
{
	public class ContextoDb : DbContext
	{
		public ContextoDb(DbContextOptions options) : base(options) { }

		public DbSet<People> Peoples { get; set; }
	}
}
