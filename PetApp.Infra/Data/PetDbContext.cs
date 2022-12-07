using Microsoft.EntityFrameworkCore;
using PetApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp.Infra.Data;

public class PetDbContext : DbContext 
{
	public PetDbContext(DbContextOptions<PetDbContext> option) : base(option)
	{

	}
	public DbSet<Especie> Especies { get; set; }
}
