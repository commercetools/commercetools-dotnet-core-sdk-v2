using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.TextSetAttribute))]
    public partial interface ITextSetAttribute : IAttribute
    {
        List<string> Value { get; set;}
    }
}
