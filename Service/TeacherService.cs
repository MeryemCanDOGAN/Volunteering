using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;
using volunteer;

public class TeacherService : ITeacherService
{

    private readonly ITeacherRepository _teacherRepository;

    public TeacherService(ITeacherRepository teacherRepository)
    {
        _teacherRepository = teacherRepository;
    }

    public async Task<ServiceResponse<Teacher>> CreateTeacher(Teacher teacher)
    {
        ServiceResponse<Teacher> response = new ServiceResponse<Teacher>();
        try
        {
            response.Data = await _teacherRepository.CreateTeacher(teacher);
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

    public async Task<ServiceResponse<Teacher>> DeleteTeacher(Teacher teacher)
    {
        ServiceResponse<Teacher> response = new ServiceResponse<Teacher>();

        try
        {
            response.Data = await _teacherRepository.DeleteTeacher(teacher);
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

    public async Task<ServiceResponse<List<Teacher>>> GetAllTeachers()
    {
          ServiceResponse<List<Teacher>> response = new ServiceResponse<List<Teacher>>();
        var add = await _teacherRepository.GetAllTeachers();

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

    public async Task<ServiceResponse<Teacher>> GetTeacherByBranch(string branch)
    {
          ServiceResponse<Teacher> response = new ServiceResponse<Teacher>();
        var add = await _teacherRepository.GetTeacherByBranch(branch);

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

    public  async Task<ServiceResponse<Teacher>> GetTeacherById(int id)
    {
       var add = await _teacherRepository.GetTeacherById(id);
       ServiceResponse<Teacher> response = new ServiceResponse<Teacher>();

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

    public async Task<ServiceResponse<Teacher>> GetTeacherByName(string name)
    {
       var add = await _teacherRepository.GetTeacherByName(name);
       ServiceResponse<Teacher> response = new ServiceResponse<Teacher>();

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

    public async Task<ServiceResponse<Teacher>> GetTeacherByPhoneNumber(int phoneNumber)
    {
       var add = await _teacherRepository.GetTeacherByPhoneNumber(phoneNumber);
       ServiceResponse<Teacher> response = new ServiceResponse<Teacher>();

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

    public async Task<ServiceResponse<Teacher>> GetTeacherBySchool(School school)
    {
       var add = await _teacherRepository.GetTeacherBySchool(school);
       ServiceResponse<Teacher> response = new ServiceResponse<Teacher>();

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

    public async Task<ServiceResponse<Teacher>> GetTeacherBySurname(string surname)
    {
         var add = await _teacherRepository.GetTeacherBySurname(surname);
       ServiceResponse<Teacher> response = new ServiceResponse<Teacher>();

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

    public async Task<ServiceResponse<Teacher>> UpdateTeacher(Teacher teacher)
    {
       var add = await _teacherRepository.UpdateTeacher(teacher);
       ServiceResponse<Teacher> response = new ServiceResponse<Teacher>();

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
}
