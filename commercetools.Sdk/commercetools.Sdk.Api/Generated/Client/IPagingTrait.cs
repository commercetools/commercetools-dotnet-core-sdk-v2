using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client
{
    public interface IPagingTrait<T> where T : IPagingTrait<T>
    {
        List<string> GetLimit();

        List<string> GetOffset();

        List<string> GetWithTotal();

        /**
         * set limit with the specificied value
         */
        T WithLimit(long limit);

        /**
         * set offset with the specificied value
         */
        T WithOffset(long offset);

        /**
         * set withTotal with the specificied value
         */
        T WithWithTotal(bool withTotal);


        IPagingTrait<T> AsPagingTrait()
        {
            return this;
        }

        T AsPagingTraitToBaseType()
        {
            return (T)this;
        }
    }
}
