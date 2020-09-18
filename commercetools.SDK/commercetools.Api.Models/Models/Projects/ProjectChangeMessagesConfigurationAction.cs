using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("changeMessagesConfiguration")]
    public class ProjectChangeMessagesConfigurationAction : ProjectUpdateAction
    {
        public MessageConfigurationDraft MessagesConfiguration { get; set;}
    }
}
