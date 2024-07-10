using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerChangePasswordQueryBuilderDsl
    {
        public CustomerChangePasswordQueryBuilderDsl()
        {
        }

        public static CustomerChangePasswordQueryBuilderDsl Of()
        {
            return new CustomerChangePasswordQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerChangePasswordQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerChangePasswordQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerChangePasswordQueryBuilderDsl>(p, CustomerChangePasswordQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerChangePasswordQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomerChangePasswordQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomerChangePasswordQueryBuilderDsl>(p, CustomerChangePasswordQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerChangePasswordQueryBuilderDsl, string> CurrentPassword()
        {
            return new ComparisonPredicateBuilder<CustomerChangePasswordQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currentPassword")),
            p => new CombinationQueryPredicate<CustomerChangePasswordQueryBuilderDsl>(p, CustomerChangePasswordQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerChangePasswordQueryBuilderDsl, string> NewPassword()
        {
            return new ComparisonPredicateBuilder<CustomerChangePasswordQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newPassword")),
            p => new CombinationQueryPredicate<CustomerChangePasswordQueryBuilderDsl>(p, CustomerChangePasswordQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
