namespace volunteer
{
    public interface ISchoolService
    {
        Task<ServiceResponse<List<School>>> GetAllSchool();
        Task<ServiceResponse<School>> GetSchoolByName(string name);
        Task<ServiceResponse<School>> GetSchoolByNumberofStudent(int numberofStudent);
        Task<ServiceResponse<School>> GetSchoolByNumberofClass(int numberofClass);
        Task<ServiceResponse<School>> GetSchoolByTeacherName(int teacherId);
        Task<ServiceResponse<School>> GetSchoolByAddress(int addressId);
        Task<ServiceResponse<School>> UpdateSchool( School school);
        Task<ServiceResponse<School>> CreateNewSchool(School school);
        Task<ServiceResponse<School>> DeleteSchool(School school);

    }
}