using System.Collections.Generic;

namespace commercetools.Sdk.Api.Client
{
    public interface IVersionedTrait<T> where T : IVersionedTrait<T>
    {
        List<string> GetVersion();

        /**
         * set version with the specificied value
         */
        T WithVersion(long version);


        IVersionedTrait<T> AsVersionedTrait()
        {
            return this;
        }

        T AsVersionedTraitToBaseType()
        {
            return (T)this;
        }
    }
}
