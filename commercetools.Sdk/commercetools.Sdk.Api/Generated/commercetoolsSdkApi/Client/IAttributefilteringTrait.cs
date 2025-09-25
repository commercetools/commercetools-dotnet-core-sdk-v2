using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client
{
    public interface IAttributefilteringTrait<T> where T : IAttributefilteringTrait<T>
    {
        List<string> GetFilterAttributes();

        /**
         * set filterAttributes with the specificied value
         */
        T WithFilterAttributes(string filterAttributes);


        IAttributefilteringTrait<T> AsAttributefilteringTrait()
        {
            return this;
        }

        T AsAttributefilteringTraitToBaseType()
        {
            return (T)this;
        }
    }
}
