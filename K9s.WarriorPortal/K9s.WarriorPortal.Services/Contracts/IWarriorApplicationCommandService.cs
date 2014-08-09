using System.Threading.Tasks;
using K9s.WarriorPortal.Models;

namespace K9s.WarriorPortal.Services.Contracts
{
    public interface IWarriorApplicationCommandService
    {
        Task AddWarriorApplicationAsync(WarriorApplication warriorApplication);
    }
}