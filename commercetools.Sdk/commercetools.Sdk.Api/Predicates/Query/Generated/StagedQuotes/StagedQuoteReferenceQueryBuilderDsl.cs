using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StagedQuotes
{

    public partial class StagedQuoteReferenceQueryBuilderDsl
    {
        public StagedQuoteReferenceQueryBuilderDsl()
        {
        }

        public static StagedQuoteReferenceQueryBuilderDsl Of()
        {
            return new StagedQuoteReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuoteReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<StagedQuoteReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<StagedQuoteReferenceQueryBuilderDsl>(p, StagedQuoteReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StagedQuoteReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StagedQuoteReferenceQueryBuilderDsl>(p, StagedQuoteReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteQueryBuilderDsl.Of())),
                StagedQuoteReferenceQueryBuilderDsl.Of);
        }


    }
}
