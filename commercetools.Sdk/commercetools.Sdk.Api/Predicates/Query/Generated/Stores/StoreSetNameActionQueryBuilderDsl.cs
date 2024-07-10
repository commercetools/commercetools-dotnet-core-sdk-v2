using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreSetNameActionQueryBuilderDsl
    {
        public StoreSetNameActionQueryBuilderDsl()
        {
        }

        public static StoreSetNameActionQueryBuilderDsl Of()
        {
            return new StoreSetNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSetNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreSetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreSetNameActionQueryBuilderDsl>(p, StoreSetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreSetNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreSetNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                StoreSetNameActionQueryBuilderDsl.Of);
        }


    }
}
