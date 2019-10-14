using ListaCursos.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListaCursos.Interfaces
{
    public interface IVideosProvider
    {
        Task<Video> GetAllAsync(string search);
    }
}
