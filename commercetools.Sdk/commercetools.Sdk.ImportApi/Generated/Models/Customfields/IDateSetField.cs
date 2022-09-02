using System.Collections.Generic;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.DateSetField))]
    public partial interface IDateSetField : ICustomField
    {
        List<Date> Value { get; set; }

    }
}
