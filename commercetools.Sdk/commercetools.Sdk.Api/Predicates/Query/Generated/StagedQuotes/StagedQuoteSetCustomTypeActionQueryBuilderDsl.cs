using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StagedQuotes
{

    public partial class StagedQuoteSetCustomTypeActionQueryBuilderDsl
    {
        public StagedQuoteSetCustomTypeActionQueryBuilderDsl()
        {
        }

        public static StagedQuoteSetCustomTypeActionQueryBuilderDsl Of()
        {
            return new StagedQuoteSetCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuoteSetCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedQuoteSetCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedQuoteSetCustomTypeActionQueryBuilderDsl>(p, StagedQuoteSetCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteSetCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteSetCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                StagedQuoteSetCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedQuoteSetCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteSetCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                StagedQuoteSetCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
