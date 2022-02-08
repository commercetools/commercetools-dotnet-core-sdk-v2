using commercetools.Api.Models.OrderEdits;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderEditAppliedMessagePayload))]
    public partial interface IOrderEditAppliedMessagePayload : IOrderMessagePayload
    {
        IOrderEditReference Edit { get; set; }

        IOrderEditApplied Result { get; set; }
    }
}
