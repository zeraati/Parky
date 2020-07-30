using System.Collections.Generic;
using ParkyAPI.Model.Entity;

namespace ParkyAPI.Repository.IRepositories
{
    public interface ITrailRepository
    { 
        bool AddTrail(Trail trail);
        bool UpdateTrail(Trail trail);
        bool RemoveTrail(Trail trail);
        bool Save();

        bool TrailExists(int trailId); 
        bool TrailExists(string trailName);
        
        ICollection<Trail> GetTrails();
        ICollection<Trail> GetTrailsInNationalPark(int nationalParkId);

        Trail GetTrail(int trailId);
    }
}
