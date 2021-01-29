using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
{
    public abstract partial class ImportRequest : IImportRequest
    {
        public IImportResourceType Type { get; set;}
    }
}
