public class Pedido{
    public int CodigoPedido { get; set; }
        public int DataPedido { get; set; }
        public bool StatusPedido { get; set; }
        public Transportadora Transportadora { get; set; }
        public List<ItemPedido> ItemPedido { get; set; }
        public Cliente Cliente { get; set; }



        public void AdicionarItem(ItemPedido item) 
        { 
            ItemPedido.Add(item);
            Console.WriteLine("Item adicionado ao carrinho: {0} ", item);
        }
        public void RemoverItem(ItemPedido item)
        { 
            ItemPedido.Remove(item);
            Console.WriteLine("Item removido do carrinho: {0} ", item);
        }
}