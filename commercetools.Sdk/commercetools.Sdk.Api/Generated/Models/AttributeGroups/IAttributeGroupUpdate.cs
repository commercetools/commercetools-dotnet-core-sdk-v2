using commercetools.Sdk.Api.Models.AttributeGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupUpdate))]
    public partial interface IAttributeGroupUpdate
    {
        long Version { get; set; }

        IList<IAttributeGroupUpdateAction> Actions { get; set; }
        IEnumerable<IAttributeGroupUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
