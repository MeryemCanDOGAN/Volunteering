using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;
using volunteer;

public class StationeryEquipmentListService : IStationeryEquipmentListService
{

    private readonly IStationeryEquipmentListRepository _stationeryEquipmentListRepository;

    public StationeryEquipmentListService(IStationeryEquipmentListRepository stationeryEquipmentListRepository)
    {
        _stationeryEquipmentListRepository = stationeryEquipmentListRepository;
    }

    public async Task<ServiceResponse<StationeryEquipmentList>> CreateStationeryEquipmentList(StationeryEquipmentList stationeryEquipmentList)
    {
                ServiceResponse<StationeryEquipmentList> response = new ServiceResponse<StationeryEquipmentList>();
        try
        {
            response.Data = await _stationeryEquipmentListRepository.CreateStationeryEquipmentList(stationeryEquipmentList);
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.Error;
            return response;
        }
    }

    public async Task<ServiceResponse<StationeryEquipmentList>> DeleteStationeryEquipmentList(StationeryEquipmentList stationeryEquipmentList)
    {
         ServiceResponse<StationeryEquipmentList> response = new ServiceResponse<StationeryEquipmentList>();

        try
        {
            response.Data = await _stationeryEquipmentListRepository.DeleteStationeryEquipmentList(stationeryEquipmentList);
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.Error;
            return response;
        }
    }

    public async Task<ServiceResponse<List<StationeryEquipmentList>>> GetAllStationeryEquipmentList()
    {
        ServiceResponse<List<StationeryEquipmentList>> response = new ServiceResponse<List<StationeryEquipmentList>>();
        var add = await _stationeryEquipmentListRepository.GetAllStationeryEquipmentList();

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }

    public async Task<ServiceResponse<StationeryEquipmentList>> GetStationeryEquipmentListById(int id)
    {
         ServiceResponse<StationeryEquipmentList> response = new ServiceResponse<StationeryEquipmentList>();
        var add = await _stationeryEquipmentListRepository.GetStationeryEquipmentListById(id);

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }
    

    public async Task<ServiceResponse<List<StationeryEquipmentList>>> GetStationeryEquipmentListByNumberOfBackpack(int Backpack)
    {
         ServiceResponse<List<StationeryEquipmentList>> response = new ServiceResponse<List<StationeryEquipmentList>>();
        var add = await _stationeryEquipmentListRepository. GetStationeryEquipmentListByNumberOfBackpack( Backpack);

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }

    public async Task<ServiceResponse<List<StationeryEquipmentList>>> GetStationeryEquipmentListByNumberOfBook(int Book)
    {
         ServiceResponse<List<StationeryEquipmentList>> response = new ServiceResponse<List<StationeryEquipmentList>>();
        var add = await _stationeryEquipmentListRepository.  GetStationeryEquipmentListByNumberOfBook( Book);

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }

    public async Task<ServiceResponse<List<StationeryEquipmentList>>> GetStationeryEquipmentListByNumberOfEraser(int Eraser)
    {
         ServiceResponse<List<StationeryEquipmentList>> response = new ServiceResponse<List<StationeryEquipmentList>>();
        var add = await _stationeryEquipmentListRepository.   GetStationeryEquipmentListByNumberOfEraser(Eraser);

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }

    public async Task<ServiceResponse<List<StationeryEquipmentList>>> GetStationeryEquipmentListByNumberOfLunchbox(int id)
    {
         ServiceResponse<List<StationeryEquipmentList>> response = new ServiceResponse<List<StationeryEquipmentList>>();
        var add = await _stationeryEquipmentListRepository.  GetStationeryEquipmentListByNumberOfLunchbox(id);

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }

    public async Task<ServiceResponse<List<StationeryEquipmentList>>> GetStationeryEquipmentListByNumberOfNotebook(int Notebook)
    {
         ServiceResponse<List<StationeryEquipmentList>> response = new ServiceResponse<List<StationeryEquipmentList>>();
        var add = await _stationeryEquipmentListRepository. GetStationeryEquipmentListByNumberOfNotebook( Notebook);

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }

    public async Task<ServiceResponse<List<StationeryEquipmentList>>> GetStationeryEquipmentListBynumberOfPencil(int Pencil)
    {
          ServiceResponse<List<StationeryEquipmentList>> response = new ServiceResponse<List<StationeryEquipmentList>>();
        var add = await _stationeryEquipmentListRepository. GetStationeryEquipmentListBynumberOfPencil(Pencil);

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }

    public async Task<ServiceResponse<StationeryEquipmentList>> GetStationeryEquipmentListBySchoolId(int SchoolId)
    {
         ServiceResponse<StationeryEquipmentList> response = new ServiceResponse<StationeryEquipmentList>();
        var add = await _stationeryEquipmentListRepository.GetStationeryEquipmentListBySchoolId(SchoolId);

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }

    public async Task<ServiceResponse<StationeryEquipmentList>> UpdateStationeryEquipmentList(StationeryEquipmentList stationeryEquipmentList)
    {
        ServiceResponse<StationeryEquipmentList> response = new ServiceResponse<StationeryEquipmentList>();
        var Coat = await _stationeryEquipmentListRepository.UpdateStationeryEquipmentList(stationeryEquipmentList);
        if (Coat != null)
        {
            response.Data = Coat;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }
}
