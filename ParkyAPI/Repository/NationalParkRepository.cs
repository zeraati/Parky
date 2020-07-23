using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParkyAPI.Data;
using ParkyAPI.Models;
using ParkyAPI.Repository.IRepository;

namespace ParkyAPI.Repository
{
    public class NationalParkRepository: INationalParkRepository
    {
        private readonly ApplicationDbContext _db;

        public NationalParkRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool AddNationalPark(NationalPark nationalPark)
        {
            _db.NationalPark.Add(nationalPark);
            return Save();
        }

        public bool UpdateNationalPark(NationalPark nationalPark)
        {
            _db.NationalPark.Update(nationalPark);
            return Save();
        }

        public bool RemoveNationalPark(NationalPark nationalPark)
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

        public ICollection<NationalPark> GetNationalParks()
        {
            return _db.NationalPark.OrderBy(x => x.Name).ToList();
        }

        public NationalPark GetNationalPark(int nationalParkId)
        {
            return _db.NationalPark.FirstOrDefault(x => x.Id == nationalParkId);
        }
    }
}
