using Microsoft.EntityFrameworkCore;
using PetApp.Core.Entities;
using PetApp.Core.Interfaces.Repositories;
using PetApp.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp.Infra.Repositories;

public class EspecieRepository : IEspecieRepository
{
    public PetDbContext _petDbContext;
	public EspecieRepository(PetDbContext petDbContext)
	{
		_petDbContext = petDbContext;
	}

	public async Task<IEnumerable<Especie>> GetAll(CancellationToken cancellation)
	{
		return await _petDbContext.Especies.ToListAsync(cancellation);
	}



}
