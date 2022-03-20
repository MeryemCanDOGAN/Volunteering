using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using FluentValidation.Results;
namespace volunteer
{
    [ApiController]
    [Route("[controller]")]
    public class StationeryEquipmentListController : ControllerBase
    {
        private readonly IStationeryEquipmentListService _stationeryEquipmentListService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public StationeryEquipmentListController(IStationeryEquipmentListService stationeryEquipmentListService)
        {
            _stationeryEquipmentListService = stationeryEquipmentListService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }
        [HttpGet("Getall")]
        public async Task<ActionResult<ServiceResponse<List<StationeryEquipmentList>>>> GetAllStationeryEquipmentList()
        {
            return await _stationeryEquipmentListService.GetAllStationeryEquipmentList();
        }
        [HttpGet("id")]
        public async Task<ActionResult<ServiceResponse<StationeryEquipmentList>>> GetStationeryEquipmentListById(int id)
        {
            return await _stationeryEquipmentListService.GetStationeryEquipmentListById(id);

        }
        [HttpGet("backpack")]
        public async Task<ActionResult<ServiceResponse<List<StationeryEquipmentList>>>> GetStationeryEquipmentListByNumberOfBackpack(int Backpack)
        {
            return await _stationeryEquipmentListService.GetStationeryEquipmentListByNumberOfBackpack(Backpack);
        }
        [HttpGet("Book")]
        public async Task<ActionResult<ServiceResponse<List<StationeryEquipmentList>>>> GetStationeryEquipmentListByNumberOfBook(int Book)
        {
            return await _stationeryEquipmentListService.GetStationeryEquipmentListByNumberOfBook(Book);
        }
        [HttpGet("Eraser")]
        public async Task<ActionResult<ServiceResponse<List<StationeryEquipmentList>>>> GetStationeryEquipmentListByNumberOfEraser(int Eraser)
        {
            return await _stationeryEquipmentListService.GetStationeryEquipmentListByNumberOfEraser(Eraser);
        }
        [HttpGet("Notebook")]
        public async Task<ActionResult<ServiceResponse<List<StationeryEquipmentList>>>> GetStationeryEquipmentListByNumberOfNotebook(int Notebook)
        {
            return await _stationeryEquipmentListService.GetStationeryEquipmentListByNumberOfNotebook(Notebook);
        }
        [HttpGet("Pencil")]
        public async Task<ActionResult<ServiceResponse<List<StationeryEquipmentList>>>> GetStationeryEquipmentListBynumberOfPencil(int Pencil)
        {
            return await _stationeryEquipmentListService.GetStationeryEquipmentListBynumberOfPencil(Pencil)
;
        }
        [HttpGet("SchoolId")]
        public async Task<ActionResult<ServiceResponse<StationeryEquipmentList>>> GetStationeryEquipmentListBySchoolId(int SchoolId)
        {
            return await _stationeryEquipmentListService.GetStationeryEquipmentListBySchoolId(SchoolId);
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<StationeryEquipmentList>>> CreateStationeryEquipmentList(StationeryEquipmentList stationeryEquipmentList)
        {
            return await _stationeryEquipmentListService.CreateStationeryEquipmentList(stationeryEquipmentList);
        }
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<StationeryEquipmentList>>> UpdateStationeryEquipmentList(StationeryEquipmentList stationeryEquipmentList)
        {
            return await _stationeryEquipmentListService.UpdateStationeryEquipmentList(stationeryEquipmentList);
        }
        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<StationeryEquipmentList>>> DeleteStationeryEquipmentList(StationeryEquipmentList stationeryEquipmentList)
        {
            return await _stationeryEquipmentListService.DeleteStationeryEquipmentList(stationeryEquipmentList);
        }
    }
}