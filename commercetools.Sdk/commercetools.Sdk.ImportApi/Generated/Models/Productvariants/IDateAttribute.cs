using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.DateAttribute))]
    public partial interface IDateAttribute : IAttribute
    {
        DateTime Value { get; set;}
    }
}
