using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditNotProcessed))]
    public partial interface IOrderEditNotProcessed : IOrderEditResult
    {
    }
}
