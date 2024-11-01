using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Core.Migrations.Entities
{
    [PrimaryKey("Id")]
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NameDescription { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
    }
}
