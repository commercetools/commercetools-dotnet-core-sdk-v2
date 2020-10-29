using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public abstract partial class ProjectUpdateAction : IProjectUpdateAction
    {
        public string Action { get; set;}
    }
}
