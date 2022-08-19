using commercetools.Sdk.Api.Models.OrderEdits;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderEditAppliedMessagePayload))]
    public partial interface IOrderEditAppliedMessagePayload : IOrderMessagePayload
    {
        IOrderEdit Edit { get; set; }

        IOrderEditApplied Result { get; set; }

    }
}
