
namespace WildFarm
{
    public class Vegetable : Food
    {
        public Vegetable(int quantity)
        {
            Quantity = quantity;
        }

        public override int Quantity { get; protected set; }
    }
}
