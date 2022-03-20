
namespace volunteer
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public int? PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender? Gender { get; set; }
        public int GenderId { get; set; }
        public Account? Account {get; set; }
        public int AccountId { get; set; }
        public Role? Role { get; set; }
        public int RoleId { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }

        public User()
        {

        }
    }
}