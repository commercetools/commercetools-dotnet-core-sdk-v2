using commercetools.Sdk.Api.Models.BusinessUnits;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociatesSetMessage))]
    public partial interface IBusinessUnitAssociatesSetMessage : IMessage
    {
        List<IAssociate> Associates { get; set; }

    }
}
