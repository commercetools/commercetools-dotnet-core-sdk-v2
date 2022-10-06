using commercetools.Sdk.Api.Models.BusinessUnits;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociatesSetMessagePayload))]
    public partial interface IBusinessUnitAssociatesSetMessagePayload : IMessagePayload
    {
        List<IAssociate> Associates { get; set; }

    }
}
