using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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
