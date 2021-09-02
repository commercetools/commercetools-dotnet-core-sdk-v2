using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class ErrorByExtension : IErrorByExtension
    {
        public string Id { get; set; }

        public string Key { get; set; }
    }
}
