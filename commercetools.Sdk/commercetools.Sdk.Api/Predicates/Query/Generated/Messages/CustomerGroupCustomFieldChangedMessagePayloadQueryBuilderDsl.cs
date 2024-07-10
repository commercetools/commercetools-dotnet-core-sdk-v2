// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl
    {
        public CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl>(p, CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl>(p, CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl>(p, CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl, string> OldValue()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldValue")),
            p => new CombinationQueryPredicate<CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl>(p, CustomerGroupCustomFieldChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
