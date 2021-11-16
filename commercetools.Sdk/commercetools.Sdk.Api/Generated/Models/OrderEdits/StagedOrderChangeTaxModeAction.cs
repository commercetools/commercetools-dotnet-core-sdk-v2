using commercetools.Api.Models.Carts;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderChangeTaxModeAction : IStagedOrderChangeTaxModeAction
    {
        public string Action { get; set; }

        public ITaxMode TaxMode { get; set; }
        public StagedOrderChangeTaxModeAction()
        {
            this.Action = "changeTaxMode";
        }
    }
}
