using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartRecalculateAction))]
    public partial interface IMyCartRecalculateAction : IMyCartUpdateAction
    {
        bool? UpdateProductData { get; set; }
    }
}
