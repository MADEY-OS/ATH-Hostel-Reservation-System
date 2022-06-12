using ATHHRS.API.Data;
using ATHHRS.API.Entities;
using ATHHRS.API.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ATHHRS.API.Services;

public interface IHostelService
{
    HostelDto GetById(int id);
    IEnumerable<HostelDto> GetAll();
    int Create(CreateHostelDto dto);
    bool Delete(int id);
    bool Update(int id, UpdateHostelDto dto);
}

public class HostelService : IHostelService
{
    private readonly ATHHRSDbContext _dbContext;
    private readonly IMapper _mapper;

    public HostelService(ATHHRSDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public HostelDto GetById(int id)
    {
        var hostel = _dbContext.Hostels.Include(r => r.Address).Include(r => r.Rooms)
            .FirstOrDefault(r => r.Id == id);

        if (hostel is null) return null;

        var result = _mapper.Map<HostelDto>(hostel);

        return result;
    }

    public IEnumerable<HostelDto> GetAll()
    {
        var hostels = _dbContext.Hostels.Include(r => r.Address).Include(r => r.Rooms).ToList();

        var hostelsDtos = _mapper.Map<List<HostelDto>>(hostels);

        return hostelsDtos;
    }

    public int Create(CreateHostelDto dto)
    {
        var hostel = _mapper.Map<Hostel>(dto);

        _dbContext.Hostels.Add(hostel);
        _dbContext.SaveChanges();

        return hostel.Id;
    }

    public bool Delete(int id)
    {
        var hostel = _dbContext.Hostels.Include(r => r.Address).Include(r => r.Rooms)
            .FirstOrDefault(r => r.Id == id);

        if (hostel is null) return false;

        _dbContext.Hostels.Remove(hostel);
        _dbContext.SaveChanges();

        return true;
    }

    public bool Update(int id, UpdateHostelDto dto)
    {
        var hostel = _dbContext.Hostels.Include(r => r.Address).Include(r => r.Rooms)
            .FirstOrDefault(r => r.Id == id);

        if (hostel is null) return false;

        hostel.Name = dto.Name;
        hostel.Description = dto.Description;
        hostel.ContactEmail = dto.ContactEmail;
        hostel.ContactNumber = dto.ContactNumber;

        _dbContext.SaveChanges();
        return true;
    }
}