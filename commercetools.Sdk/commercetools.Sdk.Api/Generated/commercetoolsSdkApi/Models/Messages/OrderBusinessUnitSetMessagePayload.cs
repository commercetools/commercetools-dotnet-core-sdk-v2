using commercetools.Sdk.Api.Models.BusinessUnits;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderBusinessUnitSetMessagePayload : IOrderBusinessUnitSetMessagePayload
    {
        public string Type { get; set; }

        public IBusinessUnitKeyReference BusinessUnit { get; set; }

        public IBusinessUnitKeyReference OldbusinessUnit { get; set; }
        public OrderBusinessUnitSetMessagePayload()
        {
            this.Type = "OrderBusinessUnitSet";
        }
    }
}
