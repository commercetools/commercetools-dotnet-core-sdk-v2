using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitContactEmailSetMessagePayload))]
    public partial interface IBusinessUnitContactEmailSetMessagePayload : IMessagePayload
    {
        string ContactEmail { get; set; }

    }
}
