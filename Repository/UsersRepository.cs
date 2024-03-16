using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SmallBasket.API.DataAcecss;
using SmallBasket.API.Entities.User;
using SmallBasket.API.Model;

namespace SmallBasket.API.Repository
{

    public interface IUsersRepository
    {
        Task<Users> CreateUser(Users_RM user);
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
    }
}
