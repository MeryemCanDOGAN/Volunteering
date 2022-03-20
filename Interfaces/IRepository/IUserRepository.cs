namespace volunteer
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUser();
        Task<User> GetUserById(int id);
        Task<User> GetUserByFirstName(string firstName);
        Task<User> GetUserByLastName(string lastName);
        Task<User> GetUserByUserName(string userName);
        Task<User> GetUserByGender( Gender gender, int genderId);
        Task<User> GetUserByRole(int id, Role role);
        Task<User> GetUserByAccount(int id, Account account);
        Task<User> GetUserByBirthDate(DateTime birthdate);
        Task<User> CreateUserOperation(User user);
        Task<User> UpdateUserOperation(int id, User user);

    }

}