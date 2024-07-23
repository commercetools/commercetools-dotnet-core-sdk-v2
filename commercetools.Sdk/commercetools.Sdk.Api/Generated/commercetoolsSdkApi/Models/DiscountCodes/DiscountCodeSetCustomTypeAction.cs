using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCodeSetCustomTypeAction : IDiscountCodeSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public DiscountCodeSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
