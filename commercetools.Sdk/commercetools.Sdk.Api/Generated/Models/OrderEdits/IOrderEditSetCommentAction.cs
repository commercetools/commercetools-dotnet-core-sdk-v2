using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetCommentAction))]
    public partial interface IOrderEditSetCommentAction : IOrderEditUpdateAction
    {
        string Comment { get; set; }

    }
}
