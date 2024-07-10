using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client
{
    public interface IDeprecatable200Trait<T> where T : IDeprecatable200Trait<T>
    {



        IDeprecatable200Trait<T> AsDeprecatable200Trait()
        {
            return this;
        }

        T AsDeprecatable200TraitToBaseType()
        {
            return (T)this;
        }
    }
}
