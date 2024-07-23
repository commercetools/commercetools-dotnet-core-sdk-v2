using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectUpdate : IProjectUpdate
    {
        public long Version { get; set; }

        public IList<IProjectUpdateAction> Actions { get; set; }
        public IEnumerable<IProjectUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
