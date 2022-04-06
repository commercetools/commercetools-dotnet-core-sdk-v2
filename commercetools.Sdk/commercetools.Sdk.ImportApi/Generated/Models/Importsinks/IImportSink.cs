using commercetools.Sdk.ImportApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importsinks
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importsinks.ImportSink))]
    public partial interface IImportSink
    {
        string Key { get; set; }

        IImportResourceType ResourceType { get; set; }

        long Version { get; set; }

        DateTime CreatedAt { get; set; }

        DateTime LastModifiedAt { get; set; }
    }
}
