using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceReferenceQueryBuilderDsl
    {
        public StandalonePriceReferenceQueryBuilderDsl()
        {
        }

        public static StandalonePriceReferenceQueryBuilderDsl Of()
        {
            return new StandalonePriceReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<StandalonePriceReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<StandalonePriceReferenceQueryBuilderDsl>(p, StandalonePriceReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StandalonePriceReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StandalonePriceReferenceQueryBuilderDsl>(p, StandalonePriceReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceQueryBuilderDsl.Of())),
                StandalonePriceReferenceQueryBuilderDsl.Of);
        }


    }
}
