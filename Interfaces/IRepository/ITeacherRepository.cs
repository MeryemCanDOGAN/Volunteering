namespace volunteer
{public interface ITeacherRepository
{
    Task<List<Teacher>> GetAllTeachers();
    Task<Teacher> GetTeacherById(int id);
    Task<Teacher> GetTeacherByName(string name);
    Task<Teacher> GetTeacherBySurname(string surname);
    Task<Teacher> GetTeacherByPhoneNumber(int phoneNumber);
    Task<Teacher> GetTeacherByBranch(string branch);
    Task<Teacher> GetTeacherBySchool(School school);
    Task<Teacher> UpdateTeacher(Teacher teacher);
    Task<Teacher> CreateTeacher(Teacher teacher);
    Task<Teacher> DeleteTeacher(Teacher teacher);


}
    
}