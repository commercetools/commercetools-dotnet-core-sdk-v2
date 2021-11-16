using System.Collections.Generic;


namespace commercetools.Api.Models.Projects
{
    public partial class ProjectUpdate : IProjectUpdate
    {
        public long Version { get; set;}
        
        public List<IProjectUpdateAction> Actions { get; set;}
    }
}
