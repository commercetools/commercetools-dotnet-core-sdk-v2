using System.Collections.Generic;

namespace commercetools.Sdk.Api.Predicates
{
    public interface ICollectionPredicate<T>: IPredicate where T: IPredicate 
    {
        public IEnumerable<T> Predicates();

    }
}