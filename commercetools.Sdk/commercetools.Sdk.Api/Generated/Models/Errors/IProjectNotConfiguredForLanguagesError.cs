using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ProjectNotConfiguredForLanguagesError))]
    public partial interface IProjectNotConfiguredForLanguagesError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IList<string> Languages { get; set; }
        IEnumerable<string> LanguagesEnumerable { set => Languages = value.ToList(); }


    }
}
