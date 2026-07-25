
namespace Heranca_e_Polimorfismo.Entities
{
    internal class ImporteProduct : Product
    {
        public double CustomFee { get; set; }

        public ImporteProduct ()
        {

        }

        public ImporteProduct (string name, double price, double customFee )
            : base (name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice ()
        {
            return Price + CustomFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + $"(taxa alfandegária: $ {CustomFee})";
        }
    }
}
