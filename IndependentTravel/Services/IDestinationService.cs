using System.Collections.Generic;
using IndependentTravel.DataModels;
namespace IndependentTravel.Services
{
    public interface IDestinationService
    {
        List<Destination> GetAll(int skip, int take);
        List<Destination> GetAllDestinations();
        int GetCount();
        void Add(Destination destination);
        Destination GetById(int id);

        void Update(Destination destination);

        void Delete(int id);

        
    }
}
