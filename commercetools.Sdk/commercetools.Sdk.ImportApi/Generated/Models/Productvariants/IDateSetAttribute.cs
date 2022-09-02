using System.Collections.Generic;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.DateSetAttribute))]
    public partial interface IDateSetAttribute : IAttribute
    {
        List<Date> Value { get; set; }

    }
}
