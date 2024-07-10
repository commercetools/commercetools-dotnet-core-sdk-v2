using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class ReturnItemQueryBuilderDsl
    {
        public ReturnItemQueryBuilderDsl()
        {
        }

        public static ReturnItemQueryBuilderDsl Of()
        {
            return new ReturnItemQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ReturnItemQueryBuilderDsl>(p, ReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ReturnItemQueryBuilderDsl>(p, ReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<ReturnItemQueryBuilderDsl>(p, ReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ReturnItemQueryBuilderDsl>(p, ReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, string> Comment()
        {
            return new ComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("comment")),
            p => new CombinationQueryPredicate<ReturnItemQueryBuilderDsl>(p, ReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, string> ShipmentState()
        {
            return new ComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipmentState")),
            p => new CombinationQueryPredicate<ReturnItemQueryBuilderDsl>(p, ReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, string> PaymentState()
        {
            return new ComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentState")),
            p => new CombinationQueryPredicate<ReturnItemQueryBuilderDsl>(p, ReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReturnItemQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReturnItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                ReturnItemQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ReturnItemQueryBuilderDsl>(p, ReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ReturnItemQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ReturnItemQueryBuilderDsl>(p, ReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ReturnItemQueryBuilderDsl> AsCustomLineItemReturnItem(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.CustomLineItemReturnItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.CustomLineItemReturnItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReturnItemQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.CustomLineItemReturnItemQueryBuilderDsl.Of()),
                ReturnItemQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReturnItemQueryBuilderDsl> AsLineItemReturnItem(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.LineItemReturnItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.LineItemReturnItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReturnItemQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.LineItemReturnItemQueryBuilderDsl.Of()),
                ReturnItemQueryBuilderDsl.Of);
        }
    }
}
