using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangeMessagesConfigurationAction : IProjectChangeMessagesConfigurationAction
    {
        public string Action { get; set; }

        public IMessagesConfigurationDraft MessagesConfiguration { get; set; }
        public ProjectChangeMessagesConfigurationAction()
        {
            this.Action = "changeMessagesConfiguration";
        }
    }
}
