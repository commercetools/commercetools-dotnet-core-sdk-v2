using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
