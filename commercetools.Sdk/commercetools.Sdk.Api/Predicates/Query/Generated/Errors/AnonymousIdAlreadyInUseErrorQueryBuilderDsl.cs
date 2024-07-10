using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class AnonymousIdAlreadyInUseErrorQueryBuilderDsl
    {
        public AnonymousIdAlreadyInUseErrorQueryBuilderDsl()
        {
        }

        public static AnonymousIdAlreadyInUseErrorQueryBuilderDsl Of()
        {
            return new AnonymousIdAlreadyInUseErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AnonymousIdAlreadyInUseErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AnonymousIdAlreadyInUseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AnonymousIdAlreadyInUseErrorQueryBuilderDsl>(p, AnonymousIdAlreadyInUseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AnonymousIdAlreadyInUseErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AnonymousIdAlreadyInUseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AnonymousIdAlreadyInUseErrorQueryBuilderDsl>(p, AnonymousIdAlreadyInUseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
