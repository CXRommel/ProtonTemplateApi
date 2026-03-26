using Proton.Models;
using Proton.Repositories;
using Proton.Repositories.DbContexts;

namespace Proton.Services;

public interface IUsersService : IBaseService<long, UserModel> {}

public class UsersService(
    IUsersRepository usersRepository//,
    // SchoolDbContext context
    // ISchoolsRepository schoolsRepository
    ) : 
    BaseService<long, UserModel>(usersRepository), IUsersService
{
    // public override async Task<UserModel> GetAsync(long id)
    // {
    //     // var user = await base.GetAsync(id);
    //     //
    //     // var user = await unitOfWork.Exec(async () =>
    //     // {
    //     //     var user1 = await usersRepository.CreateAsync(new UserModel());
    //     //     await schoolsRepository.CreateAsync(new SchoolModel() { UserId = user1.Id });
    //     //     await districtRepository.CreateAsync(new DistrictModel() { UserId = user1.Id });
    //     //
    //     //
    //     //     return user1;
    //     //
    //     // });
    //     
    //     //
    //     // await using var transaction = await context.Database.BeginTransactionAsync();
    //     //
    //     // try
    //     // {
    //     //     await usersRepository.CreateAsync(new UserModel());
    //     //     await schoolsRepository.CreateAsync(new UserModel());
    //     //     await districtRepository.CreateAsync(new UserModel());
    //     //     await beaconsRepository.CreateAsync(new UserModel());
    //     //     // await usersRepository.CreateAsync(new UserModel());
    //     //     
    //     //     // when disposed if either commands fails
    //     //     await transaction.CommitAsync();
    //     // }
    //     // catch (Exception)
    //     // {
    //     //     // TODO: Handle failure
    //     // }
    //
    //     // await context.SaveChangesAsync();
    //     
    //     // user.Schools = await schoolsRepository.GetByUserAsync(user.id);
    //
    //     return user;
    // }
}