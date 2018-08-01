using Models.Destination;
using Models.Includes;
using Models.Offers;
using System;
using System.Collections.Generic;

namespace Models.Vacations
{
    public class VacationsModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        // ACME offers resorts & cruise vacation package
        public int Resource { get; set; }

        public DestinationModel Destination { get; set; }

        public List<IncludesModel> Includes { get; set; }

        public decimal NumberOfNights { get; set; }

        // Price per person
        public float PricePP { get; set; }

        // Special offers
        public OffersModel Offer { get; set; }

        // Till what date is the package valid
        public DateTime ValidTill { get; set; }

        // Package may get sold out
        public bool SoldOut { get; set; }

        // Link to pictures
        public string Pictures { get; set; }
    }
}
