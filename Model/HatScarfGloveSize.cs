namespace volunteer
{
    public class HatScarfGloveSize
    {
        public int Id { get; set; }
      
        public int SixandEightYears { get; set; }
        public int EightandTenYears { get; set; }
        public int TenandTwelveYears { get; set; }
        public int TwelveandFourteen { get; set; }
        public School? School { get; set; }
        public int? SchoolId { get; set; }
        public int? Counts { get; set; }
        //public ICollection<ListOfRequirements> ListOfRequirements { get; set; }
    }

}