using commercetools.Sdk.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectUpdate))]
    public partial interface IProjectUpdate
    {
        long Version { get; set; }

        IList<IProjectUpdateAction> Actions { get; set; }
        IEnumerable<IProjectUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
