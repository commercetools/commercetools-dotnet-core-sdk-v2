using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client
{
    public interface IVariantattributefilteringTrait<T> where T : IVariantattributefilteringTrait<T>
    {
        List<string> GetFilterAttributes();

        /**
         * set filterAttributes with the specificied value
         */
        T WithFilterAttributes(string filterAttributes);


        IVariantattributefilteringTrait<T> AsVariantattributefilteringTrait()
        {
            return this;
        }

        T AsVariantattributefilteringTraitToBaseType()
        {
            return (T)this;
        }
    }
}
