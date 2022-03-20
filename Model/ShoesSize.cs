namespace volunteer
{public class ShoesSize
    {
    public int Id { get; set; }
    public int ThirtyTwo { get; set; }
    public int  ThirtyThree { get; set; }
    public int ThirtyFour { get; set; }
    public int ThirtyFive{ get; set; }
    public School? School { get; set; }
    public int? SchoolId { get; set; }
    public int? Counts { get; set; }
    public ICollection<ListOfRequirements>? ListOfRequirements { get; set; }
       
    }
    
}
