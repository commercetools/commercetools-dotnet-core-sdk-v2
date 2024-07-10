using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Quotes
{

    public partial class QuoteReferenceQueryBuilderDsl
    {
        public QuoteReferenceQueryBuilderDsl()
        {
        }

        public static QuoteReferenceQueryBuilderDsl Of()
        {
            return new QuoteReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<QuoteReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<QuoteReferenceQueryBuilderDsl>(p, QuoteReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<QuoteReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<QuoteReferenceQueryBuilderDsl>(p, QuoteReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteQueryBuilderDsl.Of())),
                QuoteReferenceQueryBuilderDsl.Of);
        }


    }
}
