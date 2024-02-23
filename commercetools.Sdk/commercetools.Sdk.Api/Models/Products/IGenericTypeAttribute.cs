using System;

namespace commercetools.Sdk.Api.Models.Products
{
    public interface IGenericTypeAttribute
    {
        Type GetValueType();
    }
}