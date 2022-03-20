using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using volunteer;
public class UserRepository : IUserRepository
{

  private readonly VolunteerContext _context;
     public UserRepository(VolunteerContext context)
    {
        _context = context;
    }

   

   public async Task<List<User>> GetAllUser()
    {

      return await (from db in _context.User select db).ToListAsync();
        
       
    }

    async Task<User> IUserRepository.GetUserByFirstName(string firstName)
    {
      
          return await _context.Set<User>().Where(us=>us.FirstName == firstName).FirstOrDefaultAsync();
          
                                
   
    }


    public async Task<User> GetUserById(int id)
    {
        return await _context.Set<User>().FirstOrDefaultAsync(i=>i.Id == id);
       

    }

    public async Task<User> GetUserByLastName(string lastName)
    {
       return await _context.Set<User>().Where(u=>u.LastName == lastName).FirstOrDefaultAsync();
      

    
    }

    public async Task<User> GetUserByUserName(string userName)
    {
        return await _context.Set<User>().Where(u => u.Username==userName).FirstOrDefaultAsync();
    }

    public async Task<User> UpdateUserOperation(int id, User user)
    {
       try
       {
           var us = await _context.User.FindAsync(id);
           us.FirstName=user.FirstName;
           us.LastName=user.LastName;
           us.Username= user.Username;
           us.Address= user.Address;

           await _context.SaveChangesAsync();
           return us;
       }
       catch (Exception ex)
       {
           return null;
       }
    }

    public async Task<User> CreateUserOperation(User user)
    {
     
      _context.User.AddAsync(user);
      _context.SaveChangesAsync();
      return user;
    }

    public async Task<User> GetUserByGender( Gender gender, int genderId)
    {
        return await _context.Set<User>().FirstOrDefaultAsync(u => u.GenderId==genderId);
    }

    public async Task<User> GetUserByRole(int id, Role role)
    {
         return await _context.Set<User>().Where(u => u.Role==role).FirstOrDefaultAsync();
    }

    public async Task<User> GetUserByAccount(int id, Account account)
    {
        return await _context.Set<User>().Where(u => u.Account==account).FirstOrDefaultAsync();
    }

    public async Task<User> GetUserByBirthDate(DateTime birthdate)
    {
        return await _context.Set<User>().Where(u => u.BirthDate==birthdate).FirstOrDefaultAsync();
    }
}