namespace volunteer
{
    public class Teacher
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public string Branch { get; set; }
         public virtual ICollection<School>? Schools { get; set; }
        


    }

}