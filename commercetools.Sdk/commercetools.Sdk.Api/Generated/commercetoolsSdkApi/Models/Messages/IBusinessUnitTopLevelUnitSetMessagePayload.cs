using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitTopLevelUnitSetMessagePayload))]
    public partial interface IBusinessUnitTopLevelUnitSetMessagePayload : IMessagePayload
    {
        IBusinessUnitKeyReference TopLevelUnit { get; set; }

        IBusinessUnitKeyReference OldTopLevelUnit { get; set; }

    }
}
