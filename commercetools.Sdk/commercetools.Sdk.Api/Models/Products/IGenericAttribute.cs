using System;

namespace commercetools.Api.Models.Products
{
    public interface IGenericAttribute<T>: IAttribute, IGenericTypeAttribute
    {
        T GetValue();
    }
}