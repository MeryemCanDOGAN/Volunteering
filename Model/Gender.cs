namespace volunteer
{
    public class Gender
    {
        public int Id { get; set; }
       public string Name { get; set; }
       public virtual ICollection<User> User { get; set; }

    }

}