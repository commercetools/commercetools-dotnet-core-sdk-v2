using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class ClassificationShippingRateInput : IClassificationShippingRateInput
    {
        public IShippingRateInputType Type { get; set; }

        public string Key { get; set; }

        public ILocalizedString Label { get; set; }
        public ClassificationShippingRateInput()
        {
            this.Type = IShippingRateInputType.FindEnum("Classification");
        }
    }
}
