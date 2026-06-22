using InternApiJwtAuthentication.Repositories;
using InternApiJwtAuthentication.Models;
using InternApiJwtAuthentication.DTOs;
using InternApiJwtAuthentication.Services;

namespace InternApiJwtAuthentication.Services
{
    public class UserService
    {
        private readonly UserRepository _repo;
        private readonly JwtService _jwtService;

        public UserService(UserRepository repo, JwtService jwtService)
        {
            _repo = repo;
            _jwtService = jwtService;
        }

        // LOGIN
        public string? Login(string email, string password)
        {
            var user = _repo.GetUser(email);

            if (user == null || user.PasswordHash != password)
                return null;

            return _jwtService.GenerateToken(user.Email);
        }

        // UPDATE USER
        public User? UpdateUser(int id, UserUpdateDto dto)
        {
            var user = _repo.GetById(id);
            if (user == null) return null;

            user.UserName = dto.UserName;
            user.Email = dto.Email;
            user.MobileNo = dto.MobileNo;

            _repo.Update(user);
            return user;
        }

        // DELETE USER
        public bool DeleteUser(int id)
        {
            var user = _repo.GetById(id);
            if (user == null) return false;

            _repo.Delete(user);
            return true;
        }

        // GET ALL USERS
        public IEnumerable<User> GetAllUsers()
        {
            return _repo.GetAll();
        }
    }
}