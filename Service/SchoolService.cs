using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;
using volunteer;

public class SchoolService : ISchoolService
{

    private readonly ISchoolRepository _schoolRepository;

    public SchoolService(ISchoolRepository schoolRepository)
    {
        _schoolRepository = schoolRepository;
    }

    public async Task<ServiceResponse<School>> CreateNewSchool(School school)
    {
        ServiceResponse<School> response = new ServiceResponse<School>();
        try
        {
            response.Data = await _schoolRepository.CreateNewSchool(school);
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

    public async Task<ServiceResponse<School>> DeleteSchool(School school)
    {
        ServiceResponse<School> response = new ServiceResponse<School>();

        try
        {
            response.Data = await _schoolRepository.DeleteSchool(school);
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

    public async Task<ServiceResponse<List<School>>> GetAllSchool()
    {
        ServiceResponse<List<School>> response = new ServiceResponse<List<School>>();
        var add = await _schoolRepository.GetAllSchool();

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

    public async Task<ServiceResponse<School>> GetSchoolByAddress(int addressId)
    {
        ServiceResponse<School> response = new ServiceResponse<School>();
        var add = await _schoolRepository.GetSchoolByAddress(addressId);

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

    public async Task<ServiceResponse<School>> GetSchoolByName(string name)
    {
         ServiceResponse<School> response = new ServiceResponse<School>();
        var add = await _schoolRepository.GetSchoolByName(name);

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

    public async Task<ServiceResponse<School>> GetSchoolByNumberofClass(int numberofClass)
    {
        ServiceResponse<School> response = new ServiceResponse<School>();
        var add = await _schoolRepository.GetSchoolByNumberofClass(numberofClass);

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

    public async Task<ServiceResponse<School>> GetSchoolByNumberofStudent(int numberofStudent)
    {
         ServiceResponse<School> response = new ServiceResponse<School>();
        var add = await _schoolRepository.GetSchoolByNumberofStudent(numberofStudent);

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

    public async Task<ServiceResponse<School>> GetSchoolByTeacherName(int teacherId)
    {
        ServiceResponse<School> response = new ServiceResponse<School>();
        var add = await _schoolRepository.GetSchoolByTeacherName(teacherId);

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

    public async Task<ServiceResponse<School>> UpdateSchool( School school)
    {
          ServiceResponse<School> response = new ServiceResponse<School>();
        var ExistCity = await _schoolRepository.UpdateSchool(school);
        if (ExistCity != null)
        {
            response.Data = ExistCity;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }
}