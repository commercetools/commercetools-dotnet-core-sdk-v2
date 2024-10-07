using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRolePagedQueryResponse))]
    public partial interface IAssociateRolePagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IAssociateRole> Results { get; set; }

        IEnumerable<IAssociateRole> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
