using BlissBond.Server.Data;
using BlissBond.Server.IRepository;
using BlissBond.Server.Models;
using BlissBond.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace BlissBond.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<User> _users;
        private IGenericRepository<Match> _matches;
        private IGenericRepository<Request> _requests;
        private  IGenericRepository<Message> _messages;
        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<User> Users
            => _users ??= new GenericRepository<User>(_context);
        public IGenericRepository<Match> Matches
            => _matches ??= new GenericRepository<Match>(_context);

        public IGenericRepository<Request> Requests
              => _requests ??= new GenericRepository<Request>(_context);

        public IGenericRepository<Message> Messages
            => _messages ??= new GenericRepository<Message>(_context);  

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                  
                }
            }

            await _context.SaveChangesAsync();
        }
    }

}
