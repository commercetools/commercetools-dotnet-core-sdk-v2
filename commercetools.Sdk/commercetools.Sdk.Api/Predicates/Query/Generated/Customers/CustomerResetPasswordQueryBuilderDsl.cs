using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerResetPasswordQueryBuilderDsl
    {
        public CustomerResetPasswordQueryBuilderDsl()
        {
        }

        public static CustomerResetPasswordQueryBuilderDsl Of()
        {
            return new CustomerResetPasswordQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerResetPasswordQueryBuilderDsl, string> TokenValue()
        {
            return new ComparisonPredicateBuilder<CustomerResetPasswordQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tokenValue")),
            p => new CombinationQueryPredicate<CustomerResetPasswordQueryBuilderDsl>(p, CustomerResetPasswordQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerResetPasswordQueryBuilderDsl, string> NewPassword()
        {
            return new ComparisonPredicateBuilder<CustomerResetPasswordQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newPassword")),
            p => new CombinationQueryPredicate<CustomerResetPasswordQueryBuilderDsl>(p, CustomerResetPasswordQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerResetPasswordQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomerResetPasswordQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomerResetPasswordQueryBuilderDsl>(p, CustomerResetPasswordQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
