// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetMiddleNameActionQueryBuilderDsl
    {
        public CustomerSetMiddleNameActionQueryBuilderDsl()
        {
        }

        public static CustomerSetMiddleNameActionQueryBuilderDsl Of()
        {
            return new CustomerSetMiddleNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetMiddleNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetMiddleNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetMiddleNameActionQueryBuilderDsl>(p, CustomerSetMiddleNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetMiddleNameActionQueryBuilderDsl, string> MiddleName()
        {
            return new ComparisonPredicateBuilder<CustomerSetMiddleNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("middleName")),
            p => new CombinationQueryPredicate<CustomerSetMiddleNameActionQueryBuilderDsl>(p, CustomerSetMiddleNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
