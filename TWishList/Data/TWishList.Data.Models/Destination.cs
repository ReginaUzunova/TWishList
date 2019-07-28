namespace TWishList.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Destination
    {
        public Destination()
        {
            this.Hotels = new HashSet<Hotel>();
            this.Offers = new HashSet<Offer>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public virtual ICollection<Hotel> Hotels { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }

    }
}
