using InternApiJwtAuthentication.Data;
using InternApiJwtAuthentication.Models;
using System.Collections.Generic;
using System.Linq;

namespace InternApiJwtAuthentication.Repositories
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public User? GetById(int id)
            => _context.Users.Find(id);

        public User? GetUser(string email)
            => _context.Users.FirstOrDefault(x => x.Email == email);

        public IEnumerable<User> GetAll()
            => _context.Users.ToList();

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}