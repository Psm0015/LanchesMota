using LanchesMota.Models;

namespace LanchesMota.Repositories.Interfaces;

public interface ICategoriaRepository
{
    IEnumerable<Categoria> Categorias { get; }
}
