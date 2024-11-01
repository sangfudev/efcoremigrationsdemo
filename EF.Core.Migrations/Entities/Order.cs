using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Core.Migrations.Entities
{
    [PrimaryKey("OrderNumber")]
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderNumber { get; set; }
        public int Amount { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
