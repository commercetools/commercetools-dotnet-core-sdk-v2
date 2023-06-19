using commercetools.Sdk.Api.Models.BusinessUnits;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitAssociatesSetMessagePayload))]
    public partial interface IBusinessUnitAssociatesSetMessagePayload : IMessagePayload
    {
        IList<IAssociate> Associates { get; set; }
        IEnumerable<IAssociate> AssociatesEnumerable { set => Associates = value.ToList(); }


    }
}
