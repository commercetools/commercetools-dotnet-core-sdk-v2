using System;

namespace commercetools.Api.Models.Products
{
    public interface IGenericTypeAttribute
    {
        Type GetValueType();
    }
}