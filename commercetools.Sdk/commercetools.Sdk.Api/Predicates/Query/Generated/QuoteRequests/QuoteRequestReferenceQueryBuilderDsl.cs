using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.QuoteRequests
{

    public partial class QuoteRequestReferenceQueryBuilderDsl
    {
        public QuoteRequestReferenceQueryBuilderDsl()
        {
        }

        public static QuoteRequestReferenceQueryBuilderDsl Of()
        {
            return new QuoteRequestReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRequestReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<QuoteRequestReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<QuoteRequestReferenceQueryBuilderDsl>(p, QuoteRequestReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<QuoteRequestReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<QuoteRequestReferenceQueryBuilderDsl>(p, QuoteRequestReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteRequestReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestQueryBuilderDsl.Of())),
                QuoteRequestReferenceQueryBuilderDsl.Of);
        }


    }
}
