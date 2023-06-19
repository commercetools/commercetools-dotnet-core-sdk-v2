using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ErrorResponseQueryBuilderDsl
    {
        public ErrorResponseQueryBuilderDsl()
        {
        }

        public static ErrorResponseQueryBuilderDsl Of()
        {
            return new ErrorResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ErrorResponseQueryBuilderDsl, long> StatusCode()
        {
            return new ComparisonPredicateBuilder<ErrorResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("statusCode")),
            p => new CombinationQueryPredicate<ErrorResponseQueryBuilderDsl>(p, ErrorResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ErrorResponseQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ErrorResponseQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ErrorResponseQueryBuilderDsl>(p, ErrorResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ErrorResponseQueryBuilderDsl> Errors(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("errors"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl.Of())),
                ErrorResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ErrorResponseQueryBuilderDsl> Errors()
        {
            return new CollectionPredicateBuilder<ErrorResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("errors")),
                    p => new CombinationQueryPredicate<ErrorResponseQueryBuilderDsl>(p, ErrorResponseQueryBuilderDsl.Of));
        }

        public CombinationQueryPredicate<ErrorResponseQueryBuilderDsl> AsAuthErrorResponse(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.AuthErrorResponseQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.AuthErrorResponseQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorResponseQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.AuthErrorResponseQueryBuilderDsl.Of()),
                ErrorResponseQueryBuilderDsl.Of);
        }
    }
}
