using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class CustomLineItemReturnItemQueryBuilderDsl
    {
        public CustomLineItemReturnItemQueryBuilderDsl()
        {
        }

        public static CustomLineItemReturnItemQueryBuilderDsl Of()
        {
            return new CustomLineItemReturnItemQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomLineItemReturnItemQueryBuilderDsl>(p, CustomLineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<CustomLineItemReturnItemQueryBuilderDsl>(p, CustomLineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomLineItemReturnItemQueryBuilderDsl>(p, CustomLineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, string> Comment()
        {
            return new ComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("comment")),
            p => new CombinationQueryPredicate<CustomLineItemReturnItemQueryBuilderDsl>(p, CustomLineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, string> ShipmentState()
        {
            return new ComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipmentState")),
            p => new CombinationQueryPredicate<CustomLineItemReturnItemQueryBuilderDsl>(p, CustomLineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, string> PaymentState()
        {
            return new ComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentState")),
            p => new CombinationQueryPredicate<CustomLineItemReturnItemQueryBuilderDsl>(p, CustomLineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomLineItemReturnItemQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomLineItemReturnItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                CustomLineItemReturnItemQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CustomLineItemReturnItemQueryBuilderDsl>(p, CustomLineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CustomLineItemReturnItemQueryBuilderDsl>(p, CustomLineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<CustomLineItemReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<CustomLineItemReturnItemQueryBuilderDsl>(p, CustomLineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
