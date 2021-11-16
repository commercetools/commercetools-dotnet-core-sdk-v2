using commercetools.Api.Models.OrderEdits;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderEditAppliedMessagePayload))]
    public partial interface IOrderEditAppliedMessagePayload : IMessagePayload
    {
        IOrderEditReference Edit { get; set; }

        IOrderEditApplied Result { get; set; }
    }
}
