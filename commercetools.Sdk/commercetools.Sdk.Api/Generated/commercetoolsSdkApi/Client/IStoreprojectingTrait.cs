using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client
{
    public interface IStoreprojectingTrait<T> where T : IStoreprojectingTrait<T>
    {
        List<string> GetStoreProjection();

        /**
         * set storeProjection with the specificied value
         */
        T WithStoreProjection(string storeProjection);


        IStoreprojectingTrait<T> AsStoreprojectingTrait()
        {
            return this;
        }

        T AsStoreprojectingTraitToBaseType()
        {
            return (T)this;
        }
    }
}
