using System.Collections.Generic;
using System.Linq;
using ParkyAPI.Data;
using ParkyAPI.Models;
using ParkyAPI.Repositories.IRepositories;

namespace ParkyAPI.Repositories
{
    public class NationalParkRepository: INationalParkRepository
    {
        private readonly ApplicationDbContext _db;

        public NationalParkRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool AddNationalPark(NationalParkDto nationalPark)
        {
            _db.NationalPark.Add(nationalPark);
            return Save();
        }

        public bool UpdateNationalPark(NationalParkDto nationalPark)
        {
            _db.NationalPark.Update(nationalPark);
            return Save();
        }

        public bool RemoveNationalPark(NationalParkDto nationalPark)
        {
            _db.NationalPark.Remove(nationalPark);
            return Save();
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0;
        }

        public bool NationalParkExists(int nationalParkId)
        {
            return _db.NationalPark.Any(x => x.Id == nationalParkId);
        }

        public bool NationalParkExists(string nationalParkName)
        {
            return _db.NationalPark.Any(x => 
                x.Name.ToLower().Trim() == nationalParkName.ToLower().Trim());
        }

        public ICollection<NationalParkDto> GetNationalParks()
        {
            return _db.NationalPark.OrderBy(x => x.Name).ToList();
        }

        public NationalParkDto GetNationalPark(int nationalParkId)
        {
            return _db.NationalPark.FirstOrDefault(x => x.Id == nationalParkId);
        }
    }
}
