using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class AuthErrorResponseQueryBuilderDsl
    {
        public AuthErrorResponseQueryBuilderDsl()
        {
        }

        public static AuthErrorResponseQueryBuilderDsl Of()
        {
            return new AuthErrorResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AuthErrorResponseQueryBuilderDsl, long> StatusCode()
        {
            return new ComparisonPredicateBuilder<AuthErrorResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("statusCode")),
            p => new CombinationQueryPredicate<AuthErrorResponseQueryBuilderDsl>(p, AuthErrorResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AuthErrorResponseQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AuthErrorResponseQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AuthErrorResponseQueryBuilderDsl>(p, AuthErrorResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AuthErrorResponseQueryBuilderDsl> Errors(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AuthErrorResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("errors"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl.Of())),
                AuthErrorResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AuthErrorResponseQueryBuilderDsl> Errors()
        {
            return new CollectionPredicateBuilder<AuthErrorResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("errors")),
                    p => new CombinationQueryPredicate<AuthErrorResponseQueryBuilderDsl>(p, AuthErrorResponseQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<AuthErrorResponseQueryBuilderDsl, string> Error()
        {
            return new ComparisonPredicateBuilder<AuthErrorResponseQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("error")),
            p => new CombinationQueryPredicate<AuthErrorResponseQueryBuilderDsl>(p, AuthErrorResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AuthErrorResponseQueryBuilderDsl, string> ErrorDescription()
        {
            return new ComparisonPredicateBuilder<AuthErrorResponseQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("error_description")),
            p => new CombinationQueryPredicate<AuthErrorResponseQueryBuilderDsl>(p, AuthErrorResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
