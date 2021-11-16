using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public partial class ProjectChangeCartsConfiguration : IProjectChangeCartsConfiguration
    {
        public string Action { get; set;}
        
        public ICartsConfiguration CartsConfiguration { get; set;}
        public ProjectChangeCartsConfiguration()
        { 
           this.Action = "changeCartsConfiguration";
        }
    }
}
