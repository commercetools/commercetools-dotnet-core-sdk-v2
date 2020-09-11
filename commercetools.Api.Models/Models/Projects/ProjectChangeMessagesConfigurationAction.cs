using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Projects
{
    public class ProjectChangeMessagesConfigurationAction : ProjectUpdateAction
    {
        public MessageConfigurationDraft MessagesConfiguration { get; set;}
    }
}
