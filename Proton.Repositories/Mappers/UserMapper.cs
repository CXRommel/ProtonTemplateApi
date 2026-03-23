using Proton.Common.Mapper;
using Proton.Models;
using Proton.Repositories.Entities;

namespace Proton.Repositories.Mappers;

public class UserMapper : IMapper<UserModel, UserEntity>
{
    public UserModel Map(UserEntity source)
         => new UserModel()
         {
             Id =  source.Id,
             FirstName = source.FirstName,
             LastName = source.LastName,
             Email = source.Email
         };

    public UserEntity Map(UserModel destination)
         => new UserEntity()
         {
             Id = destination.Id,
             FirstName = destination.FirstName,
             LastName = destination.LastName,
             Email = destination.Email
         };
}