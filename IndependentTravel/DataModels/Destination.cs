using System;

namespace IndependentTravel.DataModels
{
    public class Destination
    {
        private string country;
        private string town;
        public int Id { get; set; }

        public string Country
        {
            get { return this.country; }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new Exception($"Invalid country lenght: {value.Length}. The leght must be between 3 and 20");
                }

                this.country = value;
            }
        }
        public string Town
        {
            get { return this.town; }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new Exception($"Invalid town lenght: {value.Length}. The leght must be between 3 and 20");
                }

                this.town = value;
            }
        }
        public string Description { get; set; }
        public string PlaceToSleep { get; set; }
        public string PlaceToEat { get; set; }
        public string PictureURL { get; set; }
        public bool IsDeleted { get; set; }

    }
}
