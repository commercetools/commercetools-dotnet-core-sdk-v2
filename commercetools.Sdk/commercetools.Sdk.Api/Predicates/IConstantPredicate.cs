using System.Collections.Generic;

namespace commercetools.Sdk.Api.Predicates
{
    public interface IConstantPredicate: IPredicate
    {
        public string Constant();
    }
}