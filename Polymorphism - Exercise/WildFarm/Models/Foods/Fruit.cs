
namespace WildFarm
{
    public class Fruit : Food
    {
        public Fruit(int quantity)
        {
            Quantity = quantity;
        }

        public override int Quantity { get; protected set; }
    }
}
