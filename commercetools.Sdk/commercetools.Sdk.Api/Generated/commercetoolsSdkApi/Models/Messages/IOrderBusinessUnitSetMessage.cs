using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderBusinessUnitSetMessage))]
    public partial interface IOrderBusinessUnitSetMessage : IOrderMessage
    {
        IBusinessUnitKeyReference BusinessUnit { get; set; }

        IBusinessUnitKeyReference OldbusinessUnit { get; set; }

    }
}
