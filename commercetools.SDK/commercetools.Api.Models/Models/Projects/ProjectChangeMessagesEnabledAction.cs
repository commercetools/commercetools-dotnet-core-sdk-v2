using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("changeMessagesEnabled")]
    public class ProjectChangeMessagesEnabledAction : ProjectUpdateAction
    {
        public bool MessagesEnabled { get; set;}
    }
}
