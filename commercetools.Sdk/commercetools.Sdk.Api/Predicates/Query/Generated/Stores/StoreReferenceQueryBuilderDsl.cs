using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreReferenceQueryBuilderDsl
    {
        public StoreReferenceQueryBuilderDsl()
        {
        }

        public static StoreReferenceQueryBuilderDsl Of()
        {
            return new StoreReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<StoreReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<StoreReferenceQueryBuilderDsl>(p, StoreReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StoreReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StoreReferenceQueryBuilderDsl>(p, StoreReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreQueryBuilderDsl.Of())),
                StoreReferenceQueryBuilderDsl.Of);
        }


    }
}
