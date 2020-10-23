using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public  partial class ProjectChangeMessagesEnabledAction : IProjectChangeMessagesEnabledAction
    {
        public string Action { get; set;}
        
        public bool MessagesEnabled { get; set;}
        public ProjectChangeMessagesEnabledAction()
        { 
           this.Action = "changeMessagesEnabled";
        }
    }
}
