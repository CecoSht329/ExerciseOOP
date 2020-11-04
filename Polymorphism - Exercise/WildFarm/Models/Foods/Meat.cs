
namespace WildFarm
{
    public class Meat : Food
    {
        public Meat(int quantity)
        {
            Quantity = quantity;
        }

        public override int Quantity { get; protected set; }
    }
}
