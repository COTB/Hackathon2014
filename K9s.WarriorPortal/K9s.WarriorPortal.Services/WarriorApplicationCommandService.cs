using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K9s.WarriorPortal.Models;
using K9s.WarriorPortal.Services.Contracts;

namespace K9s.WarriorPortal.Services
{
    public class WarriorApplicationCommandService : IWarriorApplicationCommandService
    {
        private readonly IDbContextFactory<WarriorPortalDbContext> _dbContextFactory; 

        public WarriorApplicationCommandService(IDbContextFactory<WarriorPortalDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task AddWarriorApplicationAsync(WarriorApplication warriorApplication)
        {
            using (var context = _dbContextFactory.Create())
            {
                context.WarriorApplications.Add(warriorApplication);

                await context.SaveChangesAsync();
            }
        }
    }
}
