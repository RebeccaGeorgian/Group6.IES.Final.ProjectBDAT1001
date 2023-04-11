using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationUser.Data
{
    [Table("Service")]
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
