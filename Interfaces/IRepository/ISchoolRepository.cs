namespace volunteer
{
    public interface ISchoolRepository
    {
        Task<List<School>> GetAllSchool();
        Task<School> GetSchoolByName(string name);
        Task<School> GetSchoolByNumberofStudent(int numberofStudent);
        Task<School> GetSchoolByNumberofClass(int numberofClass);
        Task<School> GetSchoolByTeacherName(int teacherId);
        Task<School> GetSchoolByAddress(int addressId);
        Task<School> UpdateSchool( School school);
        Task<School> CreateNewSchool(School school);
        Task<School> DeleteSchool(School school);

    }
}