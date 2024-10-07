using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeLanguagesAction))]
    public partial interface IProjectChangeLanguagesAction : IProjectUpdateAction
    {
        IList<string> Languages { get; set; }

        IEnumerable<string> LanguagesEnumerable { set => Languages = value.ToList(); }

    }
}
