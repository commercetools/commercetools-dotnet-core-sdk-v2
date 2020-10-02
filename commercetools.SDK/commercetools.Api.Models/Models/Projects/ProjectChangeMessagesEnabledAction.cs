using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("changeMessagesEnabled")]
    public partial class ProjectChangeMessagesEnabledAction : ProjectUpdateAction
    {
        public bool MessagesEnabled { get; set;}
        public ProjectChangeMessagesEnabledAction()
        { 
           this.Action = "changeMessagesEnabled";
        }
    }
}
