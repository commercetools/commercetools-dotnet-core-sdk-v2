using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public partial class ProjectChangeMessagesConfigurationAction : IProjectChangeMessagesConfigurationAction
    {
        public string Action { get; set; }

        public IMessageConfigurationDraft MessagesConfiguration { get; set; }
        public ProjectChangeMessagesConfigurationAction()
        {
            this.Action = "changeMessagesConfiguration";
        }
    }
}
