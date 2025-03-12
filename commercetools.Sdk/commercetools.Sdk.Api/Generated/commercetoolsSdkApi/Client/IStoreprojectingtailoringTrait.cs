using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client
{
    public interface IStoreprojectingtailoringTrait<T> where T : IStoreprojectingtailoringTrait<T>
    {
        List<string> GetStoreProjection();

        /**
         * set storeProjection with the specificied value
         */
        T WithStoreProjection(string storeProjection);


        IStoreprojectingtailoringTrait<T> AsStoreprojectingtailoringTrait()
        {
            return this;
        }

        T AsStoreprojectingtailoringTraitToBaseType()
        {
            return (T)this;
        }
    }
}
