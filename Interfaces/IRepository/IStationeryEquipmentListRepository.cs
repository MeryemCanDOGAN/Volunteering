namespace volunteer
{
    public interface IStationeryEquipmentListRepository
    {
        Task<List<StationeryEquipmentList>> GetAllStationeryEquipmentList();
        Task<StationeryEquipmentList> GetStationeryEquipmentListById(int id);
        Task<List<StationeryEquipmentList>> GetStationeryEquipmentListByNumberOfBook(int book);
        Task<List<StationeryEquipmentList>> GetStationeryEquipmentListByNumberOfNotebook(int notebook);
        Task<List<StationeryEquipmentList>> GetStationeryEquipmentListBynumberOfPencil(int pencil);
        Task<List<StationeryEquipmentList>> GetStationeryEquipmentListByNumberOfEraser(int eraser);
        Task<List<StationeryEquipmentList>> GetStationeryEquipmentListByNumberOfBackpack(int backpack);
        Task<List<StationeryEquipmentList>> GetStationeryEquipmentListByNumberOfLunchbox(int lunchbox);
        Task<StationeryEquipmentList> GetStationeryEquipmentListBySchoolId(int schoolId);
        Task<StationeryEquipmentList> UpdateStationeryEquipmentList( StationeryEquipmentList stationeryEquipmentList);
        Task<StationeryEquipmentList> CreateStationeryEquipmentList(StationeryEquipmentList stationeryEquipmentList);
        Task<StationeryEquipmentList> DeleteStationeryEquipmentList(StationeryEquipmentList stationeryEquipmentList);

    }

}