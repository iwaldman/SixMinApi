using Microsoft.EntityFrameworkCore;
using SixMinApi.Models;

namespace SixMinApi.Data
{
    public class CommandRepo : ICommandRepo
    {
        private readonly AppDbContext _appDbContext;

        public CommandRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task CreateCommand(Command cmd)
        {
            if (cmd is null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            await _appDbContext.AddAsync(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            if (cmd is null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _appDbContext.Commands.Remove(cmd);
        }

        public async Task<IEnumerable<Command>> GetAllCommands()
        {
            return await _appDbContext.Commands.ToListAsync();
        }

        public async Task<Command?> GetCommandById(int id)
        {
            return await _appDbContext.Commands.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task SaveChanges()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
