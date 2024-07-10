// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomerGroups
{

    public partial class CustomerGroupSetCustomFieldActionQueryBuilderDsl
    {
        public CustomerGroupSetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static CustomerGroupSetCustomFieldActionQueryBuilderDsl Of()
        {
            return new CustomerGroupSetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerGroupSetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerGroupSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerGroupSetCustomFieldActionQueryBuilderDsl>(p, CustomerGroupSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupSetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomerGroupSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomerGroupSetCustomFieldActionQueryBuilderDsl>(p, CustomerGroupSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupSetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<CustomerGroupSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<CustomerGroupSetCustomFieldActionQueryBuilderDsl>(p, CustomerGroupSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
