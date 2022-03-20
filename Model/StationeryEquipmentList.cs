namespace volunteer
{
    public class StationeryEquipmentList
    {
        public int Id { get; set; }
        public int Book { get; set; }
        public int Notebook { get; set; }
        public int Pencil { get; set; }
        public int Eraser { get; set; }
        public int Backpack { get; set; }
        public int Lunchbox { get; set; }
        public int? SchoolId { get; set; }
        public School? Schoool { get; set; }
        public int? Counts { get; set; }
        public ICollection<ListOfRequirements>? ListOfRequirements { get; set; }

    }

}