using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.ConcurrentModificationError))]
    public partial interface IConcurrentModificationError : IErrorObject
    {
        long? SpecifiedVersion { get; set; }

        long CurrentVersion { get; set; }

        Object ConflictedResource { get; set; }
    }
}
