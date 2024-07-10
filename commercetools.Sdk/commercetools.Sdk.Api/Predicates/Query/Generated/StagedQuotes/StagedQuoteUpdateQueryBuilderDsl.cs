using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StagedQuotes
{

    public partial class StagedQuoteUpdateQueryBuilderDsl
    {
        public StagedQuoteUpdateQueryBuilderDsl()
        {
        }

        public static StagedQuoteUpdateQueryBuilderDsl Of()
        {
            return new StagedQuoteUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuoteUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StagedQuoteUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StagedQuoteUpdateQueryBuilderDsl>(p, StagedQuoteUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteUpdateActionQueryBuilderDsl.Of())),
                StagedQuoteUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedQuoteUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<StagedQuoteUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<StagedQuoteUpdateQueryBuilderDsl>(p, StagedQuoteUpdateQueryBuilderDsl.Of));
        }

    }
}
