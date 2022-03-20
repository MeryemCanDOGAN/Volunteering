namespace volunteer
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberofClass { get; set; }
        public int NumberofStudent { get; set; }
        public Teacher? Teacher { get; set; }
        public int? TeacherId { get; set; }
         public Address? Address { get; set; }
        public int? AddressId { get; set; }
        public virtual ICollection<ShoesSize>? ShoesSizes { get; set; }
        public virtual ICollection<CoatSize>? CoatSizes { get; set; }
         public virtual ICollection<HatScarfGloveSize>? HatScarfGloveSizes { get; set; }
       
        public virtual ICollection<StationeryEquipmentList>? StationeryEquipmentLists { get; set; }

        
    }

}