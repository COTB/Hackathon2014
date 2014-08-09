using System.Collections.Generic;
using System.Threading.Tasks;
using K9s.WarriorPortal.Models;

namespace K9s.WarriorPortal.Services.Contracts
{
    public interface IWarriorApplicationQueryService
    {
        Task<IList<WarriorApplication>> GetOpenApplicationsAsync();
    }
}