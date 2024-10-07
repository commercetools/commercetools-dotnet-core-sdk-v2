using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupPagedQueryResponse))]
    public partial interface IAttributeGroupPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IAttributeGroup> Results { get; set; }

        IEnumerable<IAttributeGroup> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
