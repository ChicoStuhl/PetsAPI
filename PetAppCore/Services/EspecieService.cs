using PetApp.Core.Entities;
using PetApp.Core.Interfaces.Repositories;
using PetApp.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp.Core.Services;

public class EspecieService : IEspecieService 
{
    private readonly IEspecieRepository _especieRepository;
    public EspecieService(IEspecieRepository especieRepository)
    {
        _especieRepository = especieRepository;
    }
    public async Task<IEnumerable<Especie>> GetAll(CancellationToken cancellationToken)
    {
        var especies = await _especieRepository.GetAll(cancellationToken);
        return especies;
    }
}
