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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeCurrenciesAction))]
    public partial interface IProjectChangeCurrenciesAction : IProjectUpdateAction
    {
        IList<string> Currencies { get; set; }
        IEnumerable<string> CurrenciesEnumerable { set => Currencies = value.ToList(); }


    }
}
