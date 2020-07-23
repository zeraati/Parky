using System.Collections.Generic;
using ParkyAPI.Models;

namespace ParkyAPI.Repositories.IRepositories
{
    public interface INationalParkRepository
    { 
        bool AddNationalPark(NationalParkDto nationalPark);
        bool UpdateNationalPark(NationalParkDto nationalPark);
        bool RemoveNationalPark(NationalParkDto nationalPark);
        bool Save();

        bool NationalParkExists(int nationalParkId); 
        bool NationalParkExists(string nationalParkName);
        
        ICollection<NationalParkDto> GetNationalParks();
        NationalParkDto GetNationalPark(int nationalParkId);
    }
}
