using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreKeyReferenceQueryBuilderDsl
    {
        public StoreKeyReferenceQueryBuilderDsl()
        {
        }

        public static StoreKeyReferenceQueryBuilderDsl Of()
        {
            return new StoreKeyReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreKeyReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<StoreKeyReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<StoreKeyReferenceQueryBuilderDsl>(p, StoreKeyReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreKeyReferenceQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<StoreKeyReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<StoreKeyReferenceQueryBuilderDsl>(p, StoreKeyReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
