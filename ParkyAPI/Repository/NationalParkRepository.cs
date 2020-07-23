using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParkyAPI.Models;

namespace ParkyAPI.Repository
{
    public class NationalParkRepository: INationalParkRepository
    {
        public ICollection<NationalPark> GetNationalParks()
        {
            throw new NotImplementedException();
        }

        public NationalPark GetNationalPark(int nationalParkId)
        {
            throw new NotImplementedException();
        }

        public bool NationalParkExists(string nationalParkName)
        {
            throw new NotImplementedException();
        }

        public bool NationalParkExists(int nationalParkId)
        {
            throw new NotImplementedException();
        }

        public bool CreateNationalPark(NationalPark nationalPark)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNationalPark(NationalPark nationalPark)
        {
            throw new NotImplementedException();
        }

        public bool DeleteNationalPark(NationalPark nationalPark)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
