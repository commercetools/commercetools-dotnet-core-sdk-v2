using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceReference))]
    public partial interface IStandalonePriceReference : IReference
    {
        new IReferenceTypeId TypeId { get; set; }

        IStandalonePrice Obj { get; set; }

    }
}
