using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SixMinApi.Models;

namespace SixMinApi.Data
{
    public interface ICommandRepo
    {
        Task SaveChanges();
        Task<Command?> GetCommandById(int id);
        Task<IEnumerable<Command>> GetAllCommands();
        Task CreateCommand(Command cmd);

        void DeleteCommand(Command cmd);
    }
}
