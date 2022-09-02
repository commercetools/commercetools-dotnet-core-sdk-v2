using commercetools.Sdk.Api.Models.OrderEdits;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderEditAppliedMessage))]
    public partial interface IOrderEditAppliedMessage : IOrderMessage
    {
        IOrderEdit Edit { get; set; }

        IOrderEditApplied Result { get; set; }

    }
}
