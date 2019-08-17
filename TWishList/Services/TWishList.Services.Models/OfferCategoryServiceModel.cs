namespace TWishList.Services.Models
{
    using System.Collections.Generic;
    using TWishList.Data.Models;
    using TWishList.Services.Mapping;

    public class OfferCategoryServiceModel : IMapFrom<OfferCategory>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public HashSet<OfferServiceModel> Offers { get; set; }
    }
}
