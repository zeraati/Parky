using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ParkyAPI.Data;
using ParkyAPI.Model.Entity;
using ParkyAPI.Repository.IRepositories;

namespace ParkyAPI.Repository
{
    public class TrailRepository : ITrailRepository
    {
        private readonly ApplicationDbContext _db;

        public TrailRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool AddTrail(Trail trail)
        {
            _db.Trail.Add(trail);
            return Save();
        }

        public bool UpdateTrail(Trail trail)
        {
            _db.Trail.Update(trail);
            return Save();
        }

        public bool RemoveTrail(Trail trail)
        {
            _db.Trail.Remove(trail);
            return Save();
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0;
        }

        public bool TrailExists(int trailId)
        {
            return _db.Trail.Any(x => x.Id == trailId);
        }

        public bool TrailExists(string trailName)
        {
            return _db.Trail.Any(x => 
                x.Name.ToLower().Trim() == trailName.ToLower().Trim());
        }

        public ICollection<Trail> GetTrails()
        {
            return _db.Trail.Include(x => x.NationalPark)
                .OrderBy(x => x.Name).ToList();
        }

        public ICollection<Trail> GetTrailsInNationalPark(int nationalParkId)
        {
            return _db.Trail.Include(x => x.NationalPark)
                .Where(x => x.NationalParkId == nationalParkId).ToList();
        }

        public Trail GetTrail(int trailId)
        {
            return _db.Trail.Include(x => x.NationalPark)
                .FirstOrDefault(x => x.Id == trailId);
        }
    }
}
