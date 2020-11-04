
namespace WildFarm
{
    public class Seeds : Food
    {
        public Seeds(int quantity)
        {
            Quantity = quantity;
        }

        public override int Quantity { get; protected set; }
    }
}
