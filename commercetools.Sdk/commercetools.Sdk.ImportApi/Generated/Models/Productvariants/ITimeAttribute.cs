using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.TimeAttribute))]
    public partial interface ITimeAttribute : IAttribute
    {
        TimeSpan Value { get; set; }
    }
}
