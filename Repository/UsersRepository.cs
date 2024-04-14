using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmallBasket.API.DataAcecss;
using SmallBasket.API.Entities.User;
using SmallBasket.API.Model;

namespace SmallBasket.API.Repository
{

    public interface IUsersRepository
    {
        Task<Users> CreateUser(Users_RM user);
        Task<Users> Login(Login_RM login);
    }
    public class UsersRepository : IUsersRepository
    {
        private readonly DataContext context;
        private readonly IMapper mapper;


        public UsersRepository(DataContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<Users> CreateUser(Users_RM user)
        {
            try
            {
                var data = mapper.Map<Users>(user);

                data.UserId = Guid.NewGuid();
                data.Name = user.Name;
                data.Email = user.Email;
                data.MobileNumber = user.MobileNumber;
                data.Password = user.Password;
                data.CreatedDate = DateTime.UtcNow;

                await context.AddAsync(data);
                await context.SaveChangesAsync();
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Users> Login(Login_RM login)
        {
            try
            {
                var user = await context.Users.Where(x => x.Email == login.UserName && x.Password == login.Password).SingleAsync();
                if (user is null)
                {
                    throw new ApplicationException("Invalid Login Credentials!!..");
                }
                else
                {
                    return user;
                }
            }
            catch
            {

                throw new ApplicationException("Invalid Login Credentials!!..");
            }


        }
    }
}
