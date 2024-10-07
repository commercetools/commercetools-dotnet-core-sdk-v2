using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetCommentAction))]
    public partial interface IOrderEditSetCommentAction : IOrderEditUpdateAction
    {
        string Comment { get; set; }

    }
}
