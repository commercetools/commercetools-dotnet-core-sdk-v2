using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategoryChangeOrderHintAction))]
    public partial interface ICategoryChangeOrderHintAction : ICategoryUpdateAction
    {
        string OrderHint { get; set; }

    }
}
