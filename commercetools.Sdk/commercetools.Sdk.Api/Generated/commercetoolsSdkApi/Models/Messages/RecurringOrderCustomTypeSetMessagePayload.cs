using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class RecurringOrderCustomTypeSetMessagePayload : IRecurringOrderCustomTypeSetMessagePayload
    {
        public string Type { get; set; }

        public ICustomFields CustomFields { get; set; }

        public string PreviousTypeId { get; set; }
        public RecurringOrderCustomTypeSetMessagePayload()
        {
            this.Type = "RecurringOrderCustomTypeSet";
        }
    }
}
