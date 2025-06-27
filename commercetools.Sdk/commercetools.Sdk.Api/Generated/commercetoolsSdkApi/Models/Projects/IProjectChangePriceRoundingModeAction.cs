using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangePriceRoundingModeAction))]
    public partial interface IProjectChangePriceRoundingModeAction : IProjectUpdateAction
    {
        IRoundingMode PriceRoundingMode { get; set; }

    }
}
