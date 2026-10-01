using SOLID.Entities;
using SOLID.Interfaces;

namespace SOLID
{
    public class SaveOrder : ISaveOrder
    {
        public void Save(Order order)
        {
            Console.WriteLine("Pedido salvo com sucesso.");
        }
    }
}
