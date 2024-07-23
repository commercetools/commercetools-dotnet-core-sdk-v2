using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.Attributes))]
    public interface IAttributes : IDictionary<string, IAttribute>
    {
    }
}
