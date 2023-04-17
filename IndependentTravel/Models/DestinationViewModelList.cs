using System.Collections.Generic;

namespace IndependentTravel.Models
{
    public class DestinationViewModelList
    {
        public List<DestinationViewModel> List { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }
    }
}
