using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.DiscountsConfiguration))]
    public partial interface IDiscountsConfiguration
    {
        IDiscountCombinationMode DiscountCombinationMode { get; set; }

    }
}
