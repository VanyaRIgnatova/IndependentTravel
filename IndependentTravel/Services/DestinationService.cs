using IndependentTravel.DataAccess;
using IndependentTravel.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace IndependentTravel.Services
{
    public class DestinationService : IDestinationService
    {
        private readonly AppDbContext db;

        public DestinationService(AppDbContext db)
        {
            this.db = db;
        }

        public void Add(Destination destination)
        {
            this.db.Destinations.Add(destination);
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            var destinationtoDelete = this.db.Destinations.FirstOrDefault(x => x.Id == id);
            if (destinationtoDelete == null) { return; }

            destinationtoDelete.IsDeleted = true;
            this.db.SaveChanges();
        }

        public List<Destination> GetAll(int skip, int take)
        {
            return this.db.Destinations
                .Where(x => x.IsDeleted == false)
                .OrderByDescending(x => x.Id)
                .Skip(skip)
                .Take(take)
                .ToList();
        }

        public List<Destination> GetAllDestinations()
        {
            return this.db.Destinations
                .Where(x => x.IsDeleted == false)
                .OrderByDescending(x => x.Id)
                .ToList();
        }

        public Destination GetById(int id)
        {
            return this.db.Destinations.FirstOrDefault(x => x.Id == id);
        }

        public int GetCount() => this.db.Destinations.Where(x => x.IsDeleted == false).Count();

        public void Update(Destination destination)
        {
           var destinationtoUpdate = this.db.Destinations.FirstOrDefault(x => x.Id == destination.Id);
            if (destinationtoUpdate == null) { return; }
            destinationtoUpdate.PictureURL = destination.PictureURL;
            destinationtoUpdate.Town = destination.Town;
            destinationtoUpdate.PlaceToSleep = destination.PlaceToSleep;
            destinationtoUpdate.PlaceToEat = destination.PlaceToEat;
            destinationtoUpdate.Country = destination.Country;
            destinationtoUpdate.Description = destination.Description;

            this.db.SaveChanges();
        }

    }
}
