using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class ClassificationShippingRateInput : IClassificationShippingRateInput
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public ILocalizedString Label { get; set; }
        public ClassificationShippingRateInput()
        {
            this.Type = "Classification";
        }
    }
}
