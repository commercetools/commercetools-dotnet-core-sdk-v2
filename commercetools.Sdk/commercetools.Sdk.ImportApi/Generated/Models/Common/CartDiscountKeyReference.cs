namespace commercetools.Sdk.ImportApi.Models.Common
{
    public partial class CartDiscountKeyReference : ICartDiscountKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public CartDiscountKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("cart-discount");
        }
    }
}
