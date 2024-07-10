using commercetools.Sdk.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangeShoppingListsConfigurationAction : IProjectChangeShoppingListsConfigurationAction
    {
        public string Action { get; set; }

        public IShoppingListsConfiguration ShoppingListsConfiguration { get; set; }
        public ProjectChangeShoppingListsConfigurationAction()
        {
            this.Action = "changeShoppingListsConfiguration";
        }
    }
}
