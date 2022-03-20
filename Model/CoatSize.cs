namespace volunteer
{
    public class CoatSize
    {
        public int Id { get; set; }
        public int SixandEightYears { get; set; }
        public int EightandTenYears { get; set; }
        public int TenandTwelveYears { get; set; }
        public int TwelveandFourteen { get; set; }
        public School? School { get; set; }
        public int? SchoolId { get; set; }
        public int? Counts { get; set; }
 
       // public ICollection<ListOfRequirements> ListOfRequirements { get; set; }
    }
/* public enum Sizes{

     SixandEightYears=1,
     EightandTenYears=2,
     TenandTwelveYears=3,
     TwelveandFourteen=4
 }*/
}