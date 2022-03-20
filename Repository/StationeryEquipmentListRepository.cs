using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using volunteer;
public class StationeryEquipmentListRepository : IStationeryEquipmentListRepository
{

    private readonly VolunteerContext _context;
    public StationeryEquipmentListRepository(VolunteerContext context)
    {
        _context = context;
    }

    public async Task<StationeryEquipmentList> CreateStationeryEquipmentList(StationeryEquipmentList stationeryEquipmentList)
    {
       await _context.Set<StationeryEquipmentList>().AddAsync(stationeryEquipmentList);
        await _context.SaveChangesAsync();
        return stationeryEquipmentList;
    }

    public async Task<StationeryEquipmentList> DeleteStationeryEquipmentList(StationeryEquipmentList stationeryEquipmentList)
    {
        _context.StationeryEquipmentLists.Remove(stationeryEquipmentList);
        await _context.SaveChangesAsync();
        return null;
    }

    public async Task<List<StationeryEquipmentList>> GetAllStationeryEquipmentList()
    {
       return await _context.Set<StationeryEquipmentList>().ToListAsync();
    }

    public async Task<StationeryEquipmentList> GetStationeryEquipmentListById(int id)
    {
         var acoat = await _context.Set<StationeryEquipmentList>().SingleOrDefaultAsync(a => a.Id== id);
        if (acoat != null)
        {
            return acoat;
        }
        return null;
    }

    public async Task<List<StationeryEquipmentList>> GetStationeryEquipmentListByNumberOfBackpack(int backpack)
    {
        List<StationeryEquipmentList> NumberOfBackpack = await (from selist in _context.StationeryEquipmentLists
                                                  orderby selist.Backpack
                                                  group selist by  selist.Backpack into Backpack


                                                  select new StationeryEquipmentList()
                                                  { Backpack =Backpack.Key,  Counts = Backpack.Count() }).ToListAsync();

        return NumberOfBackpack;
    }

    public async Task<List<StationeryEquipmentList>> GetStationeryEquipmentListByNumberOfBook(int book)
    {
         List<StationeryEquipmentList> NumberOfBook = await (from selist in _context.StationeryEquipmentLists
                                                  orderby selist.Book
                                                  group selist by  selist.Book into Book


                                                  select new StationeryEquipmentList()
                                                  { Book=Book.Key,  Counts = Book.Count() }).ToListAsync();

        return NumberOfBook;
    }

    public async Task<List<StationeryEquipmentList>> GetStationeryEquipmentListByNumberOfEraser(int eraser)
    {
       List<StationeryEquipmentList> NumberOfEraser = await (from selist in _context.StationeryEquipmentLists
                                                  orderby selist.Eraser
                                                  group selist by  selist.Eraser into Eraser


                                                  select new StationeryEquipmentList()
                                                  { Eraser=Eraser.Key,  Counts = Eraser.Count() }).ToListAsync();

        return NumberOfEraser;
    }

    public async Task<List<StationeryEquipmentList>>  GetStationeryEquipmentListByNumberOfLunchbox(int lunchbox)
    {
       List<StationeryEquipmentList> NumberOfLunchbox = await (from selist in _context.StationeryEquipmentLists
                                                  orderby selist.Lunchbox
                                                  group selist by  selist.Lunchbox into Lunchbox


                                                  select new StationeryEquipmentList()
                                                  { Lunchbox=Lunchbox.Key,  Counts = Lunchbox.Count() }).ToListAsync();

        return NumberOfLunchbox;
    }

    public async Task<List<StationeryEquipmentList>> GetStationeryEquipmentListByNumberOfNotebook(int notebook)
    {
          List<StationeryEquipmentList> NumberOfNotebook= await (from selist in _context.StationeryEquipmentLists
                                                  orderby selist.Notebook
                                                  group selist by  selist.Notebook into Notebook


                                                  select new StationeryEquipmentList()
                                                  { Notebook=Notebook.Key,  Counts = Notebook.Count() }).ToListAsync();

        return NumberOfNotebook;
    }

    public async Task<List<StationeryEquipmentList>> GetStationeryEquipmentListBynumberOfPencil(int pencil)
    {
         List<StationeryEquipmentList> numberOfPencil = await (from selist in _context.StationeryEquipmentLists
                                                  orderby selist.Pencil
                                                  group selist by  selist.Pencil into Pencil


                                                  select new StationeryEquipmentList()
                                                  { Pencil=Pencil.Key,  Counts = Pencil.Count() }).ToListAsync();

        return numberOfPencil;
    }

    public async Task<StationeryEquipmentList> GetStationeryEquipmentListBySchoolId(int schoolId)
    {
        var acoat = await _context.Set<StationeryEquipmentList>().SingleOrDefaultAsync(a => a.SchoolId == schoolId);
        if (acoat != null)
        {
            return acoat;
        }
        return null;
    }

    public async Task<StationeryEquipmentList> UpdateStationeryEquipmentList(StationeryEquipmentList stationeryEquipmentList)
    {
        _context.StationeryEquipmentLists.Update(stationeryEquipmentList);
        await _context.SaveChangesAsync();
        return stationeryEquipmentList;
    }

}
