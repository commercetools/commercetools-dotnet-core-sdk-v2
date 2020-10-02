using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("changeMessagesConfiguration")]
    public partial class ProjectChangeMessagesConfigurationAction : ProjectUpdateAction
    {
        public MessageConfigurationDraft MessagesConfiguration { get; set;}
        public ProjectChangeMessagesConfigurationAction()
        { 
           this.Action = "changeMessagesConfiguration";
        }
    }
}
