using commercetools.Sdk.Api.Models.BusinessUnits;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociatesSetMessage))]
    public partial interface IBusinessUnitAssociatesSetMessage : IMessage
    {
        IList<IAssociate> Associates { get; set; }
        IEnumerable<IAssociate> AssociatesEnumerable { set => Associates = value.ToList(); }


    }
}
