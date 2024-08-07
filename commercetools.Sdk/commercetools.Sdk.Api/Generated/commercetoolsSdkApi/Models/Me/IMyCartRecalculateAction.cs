using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartRecalculateAction))]
    public partial interface IMyCartRecalculateAction : IMyCartUpdateAction
    {
        bool? UpdateProductData { get; set; }

    }
}
