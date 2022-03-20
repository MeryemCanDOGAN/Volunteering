namespace volunteer
{
    public class ListOfRequirements
    {
        public int Id { get; set; }
        public int CoatSizeId { get; set; }
        public CoatSize CoatSize { get; set; }
        public int HatScarfGloveSizeId { get; set; }
        public HatScarfGloveSize  HatScarfGloveSize { get; set; }
        public int ShoesSizeId { get; set; }
        public ShoesSize ShoesSize { get; set; }
        public int StationeryEquipmentListId { get; set; }
        public StationeryEquipmentList EquipmentList { get; set; }
        
    }
    
}