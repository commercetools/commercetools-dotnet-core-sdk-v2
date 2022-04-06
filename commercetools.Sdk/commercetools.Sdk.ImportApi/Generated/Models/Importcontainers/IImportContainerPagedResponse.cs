using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importcontainers
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importcontainers.ImportContainerPagedResponse))]
    public partial interface IImportContainerPagedResponse
    {
        int Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long Total { get; set; }

        List<IImportContainer> Results { get; set; }
    }
}
