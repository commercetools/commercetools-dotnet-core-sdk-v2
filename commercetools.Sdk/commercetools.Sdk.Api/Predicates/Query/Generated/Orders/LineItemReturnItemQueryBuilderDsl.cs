using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class LineItemReturnItemQueryBuilderDsl
    {
        public LineItemReturnItemQueryBuilderDsl()
        {
        }

        public static LineItemReturnItemQueryBuilderDsl Of()
        {
            return new LineItemReturnItemQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<LineItemReturnItemQueryBuilderDsl>(p, LineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<LineItemReturnItemQueryBuilderDsl>(p, LineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<LineItemReturnItemQueryBuilderDsl>(p, LineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<LineItemReturnItemQueryBuilderDsl>(p, LineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, string> Comment()
        {
            return new ComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("comment")),
            p => new CombinationQueryPredicate<LineItemReturnItemQueryBuilderDsl>(p, LineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, string> ShipmentState()
        {
            return new ComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipmentState")),
            p => new CombinationQueryPredicate<LineItemReturnItemQueryBuilderDsl>(p, LineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, string> PaymentState()
        {
            return new ComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentState")),
            p => new CombinationQueryPredicate<LineItemReturnItemQueryBuilderDsl>(p, LineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<LineItemReturnItemQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LineItemReturnItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                LineItemReturnItemQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<LineItemReturnItemQueryBuilderDsl>(p, LineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<LineItemReturnItemQueryBuilderDsl>(p, LineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<LineItemReturnItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<LineItemReturnItemQueryBuilderDsl>(p, LineItemReturnItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
