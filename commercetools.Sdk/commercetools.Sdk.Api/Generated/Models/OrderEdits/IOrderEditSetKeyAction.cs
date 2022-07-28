using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetKeyAction))]
    public partial interface IOrderEditSetKeyAction : IOrderEditUpdateAction
    {
        string Key { get; set; }

    }
}
