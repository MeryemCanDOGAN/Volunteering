using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using volunteer;
public class TeacherRepository : ITeacherRepository
{

    private readonly VolunteerContext _context;
    public TeacherRepository(VolunteerContext context)
    {
        _context = context;
    }

    public async Task<Teacher> CreateTeacher(Teacher teacher)
    {
        
        await _context.Set<Teacher>().AddAsync(teacher);
        await _context.SaveChangesAsync();
        return teacher;
    }

    public async Task<Teacher> DeleteTeacher(Teacher teacher)
    {
            _context.Teachers.Remove(teacher);
        await _context.SaveChangesAsync();
        return null;
    }

    public async Task<List<Teacher>> GetAllTeachers()
    {
         return await _context.Set<Teacher>().ToListAsync();
    }

    public async Task<Teacher> GetTeacherByBranch(string branch)
    {
       var acoat = await _context.Set<Teacher>().SingleOrDefaultAsync(a => a.Branch == branch);
        if (acoat != null)
        {
            return acoat;
        }
        return null;
    }

    public async Task<Teacher> GetTeacherById(int id)
    {
        var acoat = await _context.Set<Teacher>().SingleOrDefaultAsync(a => a.Id == id);
        if (acoat != null)
        {
            return acoat;
        }
        return null;
    }

    public async Task<Teacher> GetTeacherByName(string name)
    {
         var acoat = await _context.Set<Teacher>().SingleOrDefaultAsync(a => a.Name == name);
        if (acoat != null)
        {
            return acoat;
        }
        return null;
    }

    public async Task<Teacher> GetTeacherByPhoneNumber(int phoneNumber)
    {
          var acoat = await _context.Set<Teacher>().SingleOrDefaultAsync(a => a.PhoneNumber == phoneNumber);
        if (acoat != null)
        {
            return acoat;
        }
        return null;
    }

    public async Task<Teacher> GetTeacherBySchool(School school)
    {
          var acoat = await _context.Set<Teacher>().SingleOrDefaultAsync(a => a.Schools ==school);
        if (acoat != null)
        {
            return acoat;
        }
        return null;
    }

    public async Task<Teacher> GetTeacherBySurname(string surname)
    {
         var acoat = await _context.Set<Teacher>().SingleOrDefaultAsync(a => a.Surname ==surname);
        if (acoat != null)
        {
            return acoat;
        }
        return null;
    }

    public async Task<Teacher> UpdateTeacher(Teacher teacher)
    {
        _context.Teachers.Update(teacher);
        await _context.SaveChangesAsync();
        return teacher;
    }
}
