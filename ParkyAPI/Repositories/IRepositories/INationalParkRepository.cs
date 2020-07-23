using System.Collections.Generic;
using ParkyAPI.Models;

namespace ParkyAPI.Repositories.IRepositories
{
    public interface INationalParkRepository
    { 
        bool AddNationalPark(NationalPark nationalPark);
        bool UpdateNationalPark(NationalPark nationalPark);
        bool RemoveNationalPark(NationalPark nationalPark);
        bool Save();

        bool NationalParkExists(int nationalParkId); 
        bool NationalParkExists(string nationalParkName);
        
        ICollection<NationalPark> GetNationalParks();
        NationalPark GetNationalPark(int nationalParkId);
    }
}
