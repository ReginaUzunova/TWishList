namespace TWishList.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using TWishList.Data.Common.Models;

    public class Hotel : BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }

        public int Rating { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int DestinationId { get; set; }
        public virtual Destination Destination { get; set; }
    }
}
