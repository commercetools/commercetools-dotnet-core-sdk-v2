// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomerGroups
{

    public partial class CustomerGroupChangeNameActionQueryBuilderDsl
    {
        public CustomerGroupChangeNameActionQueryBuilderDsl()
        {
        }

        public static CustomerGroupChangeNameActionQueryBuilderDsl Of()
        {
            return new CustomerGroupChangeNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerGroupChangeNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerGroupChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerGroupChangeNameActionQueryBuilderDsl>(p, CustomerGroupChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupChangeNameActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomerGroupChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomerGroupChangeNameActionQueryBuilderDsl>(p, CustomerGroupChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
