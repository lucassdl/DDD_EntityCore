using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("Pedido")]
    public class Pedido
    {
        [Column(name:"PEDI_Id")]
        public int Id { get; set; }
        [Column(name:"PEDI_Nome")]
        public string NomeDoPedido { get; set; }
        public virtual IEnumerable<ItemDoPedido> ItensDoPedido { get; set; }
    }
}
