using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRolePagedQueryResponse : IAssociateRolePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IAssociateRole> Results { get; set; }

        public IEnumerable<IAssociateRole> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
