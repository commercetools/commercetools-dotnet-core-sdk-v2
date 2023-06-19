using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetCustomerGroupActionQueryBuilderDsl
    {
        public CustomerSetCustomerGroupActionQueryBuilderDsl()
        {
        }

        public static CustomerSetCustomerGroupActionQueryBuilderDsl Of()
        {
            return new CustomerSetCustomerGroupActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetCustomerGroupActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetCustomerGroupActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetCustomerGroupActionQueryBuilderDsl>(p, CustomerSetCustomerGroupActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerSetCustomerGroupActionQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerSetCustomerGroupActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                CustomerSetCustomerGroupActionQueryBuilderDsl.Of);
        }


    }
}
