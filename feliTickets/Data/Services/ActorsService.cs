using feliTickets.Data.Base;
using feliTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace feliTickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context ) : base(context ) 
        {

        }
       

    }
}
