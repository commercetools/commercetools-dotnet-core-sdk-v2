using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class ImportOperationRejectedEventQueryBuilderDsl
    {
        public ImportOperationRejectedEventQueryBuilderDsl()
        {
        }

        public static ImportOperationRejectedEventQueryBuilderDsl Of()
        {
            return new ImportOperationRejectedEventQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ImportOperationRejectedEventQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ImportOperationRejectedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ImportOperationRejectedEventQueryBuilderDsl>(p, ImportOperationRejectedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportOperationRejectedEventQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<ImportOperationRejectedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<ImportOperationRejectedEventQueryBuilderDsl>(p, ImportOperationRejectedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportOperationRejectedEventQueryBuilderDsl, string> ResourceType()
        {
            return new ComparisonPredicateBuilder<ImportOperationRejectedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceType")),
            p => new CombinationQueryPredicate<ImportOperationRejectedEventQueryBuilderDsl>(p, ImportOperationRejectedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportOperationRejectedEventQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ImportOperationRejectedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ImportOperationRejectedEventQueryBuilderDsl>(p, ImportOperationRejectedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportOperationRejectedEventQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ImportOperationRejectedEventQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ImportOperationRejectedEventQueryBuilderDsl>(p, ImportOperationRejectedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ImportOperationRejectedEventQueryBuilderDsl> Data(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.ImportOperationRejectedEventDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.ImportOperationRejectedEventDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ImportOperationRejectedEventQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("data"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.ImportOperationRejectedEventDataQueryBuilderDsl.Of())),
                ImportOperationRejectedEventQueryBuilderDsl.Of);
        }


    }
}
