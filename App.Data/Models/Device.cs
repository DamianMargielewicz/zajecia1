using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Models
{
    [Table(nameof(Device))]
    public class Device
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required, ForeignKey(nameof(DeviceType))]
        public int DeviceTypeId { get; set; }

        [Required, ForeignKey(nameof(Place))]
        public int PlaceId { get; set; }

        public virtual DeviceType DeviceType { get; set; }
        public virtual Place Place { get; set; }
    }
}
