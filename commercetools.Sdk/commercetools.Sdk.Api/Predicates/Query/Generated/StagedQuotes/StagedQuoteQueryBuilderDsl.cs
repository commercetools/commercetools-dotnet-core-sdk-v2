using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StagedQuotes
{

    public partial class StagedQuoteQueryBuilderDsl
    {
        public StagedQuoteQueryBuilderDsl()
        {
        }

        public static StagedQuoteQueryBuilderDsl Of()
        {
            return new StagedQuoteQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(p, StagedQuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(p, StagedQuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(p, StagedQuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(p, StagedQuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(p, StagedQuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StagedQuoteQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedQuoteQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StagedQuoteQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, string> StagedQuoteState()
        {
            return new ComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stagedQuoteState")),
            p => new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(p, StagedQuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                StagedQuoteQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedQuoteQueryBuilderDsl> QuoteRequest(
            Func<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("quoteRequest"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestReferenceQueryBuilderDsl.Of())),
                StagedQuoteQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedQuoteQueryBuilderDsl> QuotationCart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("quotationCart"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartReferenceQueryBuilderDsl.Of())),
                StagedQuoteQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, DateTime> ValidTo()
        {
            return new ComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validTo")),
            p => new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(p, StagedQuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, string> SellerComment()
        {
            return new ComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sellerComment")),
            p => new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(p, StagedQuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                StagedQuoteQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedQuoteQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                StagedQuoteQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, string> PurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<StagedQuoteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("purchaseOrderNumber")),
            p => new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(p, StagedQuoteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                StagedQuoteQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedQuoteQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                StagedQuoteQueryBuilderDsl.Of);
        }


    }
}
