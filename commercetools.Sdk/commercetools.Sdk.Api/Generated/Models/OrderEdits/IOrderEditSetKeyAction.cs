using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditSetKeyAction))]
    public partial interface IOrderEditSetKeyAction : IOrderEditUpdateAction
    {
        string Key { get; set; }
    }
}
