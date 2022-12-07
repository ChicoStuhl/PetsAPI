using PetApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp.Core.Interfaces.Repositories;

public interface IEspecieRepository
{
    Task<IEnumerable<Especie>> GetAll(CancellationToken cancellation);

    Task<Especie> BuscarTodasEspecies();
    Task<Especie> BuscarPorId(int id);
    Task<Especie> Adicionar(Especie especie);
    Task<Especie> Deletar(int id);
    Task<Especie> Atualizar(Especie especie, int id);
    Task<bool> Apagar(Especie especie, int id);

}
