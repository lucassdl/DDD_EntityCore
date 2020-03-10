using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("ItemDoPedido")]
    public class ItemDoPedido
    {
        [Column(name:"ITEM_Id")]
        public int Id { get; set; }
        [Column(name: "ITEM_Nome")]
        public string NomeDoItem { get; set; }
        [Column(name:"PEDI_Id")]
        [ForeignKey("Pedido")]
        public int IdDoPedido { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
