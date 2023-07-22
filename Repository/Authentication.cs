using ispat.DbContexts;
using ispat.DTO.Authentication;
using ispat.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ispat.Repository
{
    public class Authentication : IAuthentication
    {
        private readonly ReadWriteContext _context;
        public Authentication(ReadWriteContext Context)
        {
            _context = Context;
        }
        public async Task<string> LogIn(LogInDTO obj)
        {
            return $"Invalid Credential!";
        }
    }
}
