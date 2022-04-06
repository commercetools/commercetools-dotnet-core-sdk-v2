using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importsinks
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importsinks.ImportSinkPagedResponse))]
    public partial interface IImportSinkPagedResponse
    {
        int Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long Total { get; set; }

        List<IImportSink> Results { get; set; }
    }
}
