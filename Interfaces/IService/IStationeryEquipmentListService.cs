namespace volunteer
{
    public interface IStationeryEquipmentListService
    {
        Task<ServiceResponse<List<StationeryEquipmentList>>> GetAllStationeryEquipmentList();
        Task<ServiceResponse<StationeryEquipmentList>> GetStationeryEquipmentListById(int id);
        Task<ServiceResponse<List<StationeryEquipmentList>>> GetStationeryEquipmentListByNumberOfBook(int Book);
        Task<ServiceResponse<List<StationeryEquipmentList>>> GetStationeryEquipmentListByNumberOfNotebook(int Notebook);
        Task<ServiceResponse<List<StationeryEquipmentList>>> GetStationeryEquipmentListBynumberOfPencil(int Pencil);
        Task<ServiceResponse<List<StationeryEquipmentList>>> GetStationeryEquipmentListByNumberOfEraser(int Eraser);
        Task<ServiceResponse<List<StationeryEquipmentList>>> GetStationeryEquipmentListByNumberOfBackpack(int Backpack);
        Task<ServiceResponse<List<StationeryEquipmentList>>> GetStationeryEquipmentListByNumberOfLunchbox(int id);
         Task<ServiceResponse<StationeryEquipmentList>> GetStationeryEquipmentListBySchoolId(int SchoolId);
        Task<ServiceResponse<StationeryEquipmentList>> UpdateStationeryEquipmentList(StationeryEquipmentList stationeryEquipmentList);
        Task<ServiceResponse<StationeryEquipmentList>> CreateStationeryEquipmentList(StationeryEquipmentList stationeryEquipmentList);
        Task<ServiceResponse<StationeryEquipmentList>> DeleteStationeryEquipmentList(StationeryEquipmentList stationeryEquipmentList);

    }

}