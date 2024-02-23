using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerCustomTypeSetMessagePayloadQueryBuilderDsl
    {
        public CustomerCustomTypeSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerCustomTypeSetMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerCustomTypeSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerCustomTypeSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerCustomTypeSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerCustomTypeSetMessagePayloadQueryBuilderDsl>(p, CustomerCustomTypeSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerCustomTypeSetMessagePayloadQueryBuilderDsl> CustomFields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerCustomTypeSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customFields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                CustomerCustomTypeSetMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerCustomTypeSetMessagePayloadQueryBuilderDsl, string> PreviousTypeId()
        {
            return new ComparisonPredicateBuilder<CustomerCustomTypeSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("previousTypeId")),
            p => new CombinationQueryPredicate<CustomerCustomTypeSetMessagePayloadQueryBuilderDsl>(p, CustomerCustomTypeSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
