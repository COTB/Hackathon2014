using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using K9s.WarriorPortal.Models;
using K9s.WarriorPortal.Models.Enum;
using K9s.WarriorPortal.Services.Contracts;

namespace K9s.WarriorPortal.Services
{
    public class WarriorApplicationQueryService : IWarriorApplicationQueryService
    {
        private static readonly IEnumerable<ApplicationStatus> OpenStatuses =
            new[] {ApplicationStatus.Applied, ApplicationStatus.Processing };

        private readonly IDbContextFactory<WarriorPortalDbContext> _dbContextFactory;

        public WarriorApplicationQueryService(IDbContextFactory<WarriorPortalDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<IList<WarriorApplication>> GetOpenApplicationsAsync()
        {
            using (var context = _dbContextFactory.Create())
            {
                return await context.WarriorApplications
                    .Where(application => OpenStatuses.Contains(application.ApplicationStatus))
                    .ToListAsync();
            }
        }
    }
}
