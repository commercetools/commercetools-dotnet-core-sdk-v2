using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ProjectNotConfiguredForLanguagesError))]
    public partial interface IProjectNotConfiguredForLanguagesError : IErrorObject
    {
        List<string> Languages { get; set; }

    }
}
