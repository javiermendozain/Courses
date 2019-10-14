using ListaCursos.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListaCursos.Interfaces
{
    public interface IMessageProvider
    {
        Message GetMessage();

        Task<bool> SendMessage(string search);

    }
}
