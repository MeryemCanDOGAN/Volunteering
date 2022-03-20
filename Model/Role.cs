namespace volunteer
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
       public virtual ICollection<User> User { get; set; }
       
    }

}