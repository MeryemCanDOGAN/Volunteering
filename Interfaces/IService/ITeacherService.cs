namespace volunteer
{
    public interface ITeacherService
    {
        Task<ServiceResponse<List<Teacher>>> GetAllTeachers();
        Task<ServiceResponse<Teacher>> GetTeacherById(int id);
        Task<ServiceResponse<Teacher>> GetTeacherByName(string name);
        Task<ServiceResponse<Teacher>>GetTeacherBySurname(string surname);
        Task<ServiceResponse<Teacher>> GetTeacherByPhoneNumber(int phoneNumber);
        Task<ServiceResponse<Teacher>> GetTeacherByBranch(string branch);
        Task<ServiceResponse<Teacher>> GetTeacherBySchool(School school);
        Task<ServiceResponse<Teacher>> UpdateTeacher(Teacher teacher);
        Task<ServiceResponse<Teacher>> CreateTeacher(Teacher teacher);
        Task<ServiceResponse<Teacher>> DeleteTeacher(Teacher teacher);


    }

}