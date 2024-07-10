// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetSalutationActionQueryBuilderDsl
    {
        public CustomerSetSalutationActionQueryBuilderDsl()
        {
        }

        public static CustomerSetSalutationActionQueryBuilderDsl Of()
        {
            return new CustomerSetSalutationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetSalutationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetSalutationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetSalutationActionQueryBuilderDsl>(p, CustomerSetSalutationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetSalutationActionQueryBuilderDsl, string> Salutation()
        {
            return new ComparisonPredicateBuilder<CustomerSetSalutationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("salutation")),
            p => new CombinationQueryPredicate<CustomerSetSalutationActionQueryBuilderDsl>(p, CustomerSetSalutationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
