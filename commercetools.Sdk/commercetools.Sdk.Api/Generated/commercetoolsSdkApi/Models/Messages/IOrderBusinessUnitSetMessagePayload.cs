using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderBusinessUnitSetMessagePayload))]
    public partial interface IOrderBusinessUnitSetMessagePayload : IOrderMessagePayload
    {
        IBusinessUnitKeyReference BusinessUnit { get; set; }

        IBusinessUnitKeyReference OldbusinessUnit { get; set; }

    }
}
