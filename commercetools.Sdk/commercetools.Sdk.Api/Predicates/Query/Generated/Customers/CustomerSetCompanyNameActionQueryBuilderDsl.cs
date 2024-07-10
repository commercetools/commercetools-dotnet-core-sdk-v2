using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetCompanyNameActionQueryBuilderDsl
    {
        public CustomerSetCompanyNameActionQueryBuilderDsl()
        {
        }

        public static CustomerSetCompanyNameActionQueryBuilderDsl Of()
        {
            return new CustomerSetCompanyNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetCompanyNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetCompanyNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetCompanyNameActionQueryBuilderDsl>(p, CustomerSetCompanyNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetCompanyNameActionQueryBuilderDsl, string> CompanyName()
        {
            return new ComparisonPredicateBuilder<CustomerSetCompanyNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("companyName")),
            p => new CombinationQueryPredicate<CustomerSetCompanyNameActionQueryBuilderDsl>(p, CustomerSetCompanyNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
