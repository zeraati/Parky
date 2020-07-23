using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParkyAPI.Models;

// ReSharper disable once CheckNamespace
namespace ParkyAPI.Repository
{
    public interface INationalParkRepository
    {
        ICollection<NationalPark> GetNationalParks();
        NationalPark GetNationalPark(int nationalParkId);
        bool NationalParkExists(string nationalParkName);
        bool NationalParkExists(int nationalParkId);
        bool CreateNationalPark(NationalPark nationalPark);
        bool UpdateNationalPark(NationalPark nationalPark);
        bool DeleteNationalPark(NationalPark nationalPark);
        bool Save();
    }
}
