namespace volunteer
{
    public class Account
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsVisibility { get; set; }
        public virtual ICollection<User>? User { get; set; }
        public Account()
        {


        }
     
        public Account(Account account )
        {
            this.Id = account.Id;
            this.Email =account.Email;
            this.Password = account.Password;
            this.IsBlocked = account.IsBlocked;
            this.IsVisibility = account.IsVisibility;
            this.User=account.User;
           
           
        }

    }
}