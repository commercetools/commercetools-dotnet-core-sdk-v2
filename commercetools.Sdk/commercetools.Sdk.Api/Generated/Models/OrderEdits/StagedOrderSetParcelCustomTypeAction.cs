using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetParcelCustomTypeAction : IStagedOrderSetParcelCustomTypeAction
    {
        public string Action { get; set; }

        public string ParcelId { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public StagedOrderSetParcelCustomTypeAction()
        {
            this.Action = "setParcelCustomType";
        }
    }
}
