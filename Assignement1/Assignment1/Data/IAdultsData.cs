using System.Collections.Generic;
using Models;

namespace Assignment1.Data
{
    public interface IAdultsData
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(int adultId);
        void Edit(Adult adult);
        Adult Get(int id);

    }
}