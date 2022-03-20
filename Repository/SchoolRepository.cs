using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using volunteer;
public class SchoolRepository : ISchoolRepository
{

    private readonly VolunteerContext _context;
    public SchoolRepository(VolunteerContext context)
    {
        _context = context;
    }

    public async Task<School> CreateNewSchool(School school)
    {
        await _context.Set<School>().AddAsync(school);
        await _context.SaveChangesAsync();
        return school;
    }

    public async Task<School> DeleteSchool(School school)
    {
        _context.Schools.Remove(school);
        await _context.SaveChangesAsync();
        return null;
    }

    public async Task<List<School>> GetAllSchool()
    {
         return await _context.Set<School>().ToListAsync();
    }

    public async Task<School> GetSchoolByAddress(int addressId)
    {
         var aSchool = await _context.Set<School>().SingleOrDefaultAsync(a=>a.AddressId==addressId);
        if(aSchool !=null)
        {
            return aSchool;
        }
        return null;
    }

    public async Task<School> GetSchoolByName(string name)
    {
         var aSchool = await _context.Set<School>().SingleOrDefaultAsync(a=>a.Name==name);
        if(aSchool !=null)
        {
            return aSchool;
        }
        return null;
    }

    public async Task<School> GetSchoolByNumberofClass(int numberofClass)
    {
          var aSchool = await _context.Set<School>().SingleOrDefaultAsync(a=>a.NumberofClass==numberofClass);
        if(aSchool !=null)
        {
            return aSchool;
        }
        return null;
    }

    public async Task<School> GetSchoolByNumberofStudent(int numberofStudent)
    {
          var aSchool = await _context.Set<School>().SingleOrDefaultAsync(a=>a.NumberofStudent==numberofStudent);
        if(aSchool !=null)
        {
            return aSchool;
        }
        return null;
    }

    public async Task<School> GetSchoolByTeacherName(int teacherId)
    {
          var aSchool = await _context.Set<School>().SingleOrDefaultAsync(a=>a.TeacherId==teacherId);
        if(aSchool !=null)
        {
            return aSchool;
        }
        return null;
    }

    public async Task<School> UpdateSchool(School school)
    {
        _context.Schools.Update(school);
        await _context.SaveChangesAsync();
        return school;
    }
}
