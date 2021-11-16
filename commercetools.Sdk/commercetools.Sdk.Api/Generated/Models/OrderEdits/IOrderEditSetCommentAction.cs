using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditSetCommentAction))]
    public partial interface IOrderEditSetCommentAction : IOrderEditUpdateAction
    {
        string Comment { get; set;}
    }
}
