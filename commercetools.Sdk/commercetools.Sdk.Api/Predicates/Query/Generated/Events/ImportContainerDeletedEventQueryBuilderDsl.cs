using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class ImportContainerDeletedEventQueryBuilderDsl
    {
        public ImportContainerDeletedEventQueryBuilderDsl()
        {
        }

        public static ImportContainerDeletedEventQueryBuilderDsl Of()
        {
            return new ImportContainerDeletedEventQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ImportContainerDeletedEventQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ImportContainerDeletedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ImportContainerDeletedEventQueryBuilderDsl>(p, ImportContainerDeletedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportContainerDeletedEventQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<ImportContainerDeletedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<ImportContainerDeletedEventQueryBuilderDsl>(p, ImportContainerDeletedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportContainerDeletedEventQueryBuilderDsl, string> ResourceType()
        {
            return new ComparisonPredicateBuilder<ImportContainerDeletedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceType")),
            p => new CombinationQueryPredicate<ImportContainerDeletedEventQueryBuilderDsl>(p, ImportContainerDeletedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportContainerDeletedEventQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ImportContainerDeletedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ImportContainerDeletedEventQueryBuilderDsl>(p, ImportContainerDeletedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportContainerDeletedEventQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ImportContainerDeletedEventQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ImportContainerDeletedEventQueryBuilderDsl>(p, ImportContainerDeletedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ImportContainerDeletedEventQueryBuilderDsl> Data(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.ImportContainerDeletedEventDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.ImportContainerDeletedEventDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ImportContainerDeletedEventQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("data"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.ImportContainerDeletedEventDataQueryBuilderDsl.Of())),
                ImportContainerDeletedEventQueryBuilderDsl.Of);
        }


    }
}
