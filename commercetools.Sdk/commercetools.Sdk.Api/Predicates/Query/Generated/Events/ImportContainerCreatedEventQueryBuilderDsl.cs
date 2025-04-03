using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class ImportContainerCreatedEventQueryBuilderDsl
    {
        public ImportContainerCreatedEventQueryBuilderDsl()
        {
        }

        public static ImportContainerCreatedEventQueryBuilderDsl Of()
        {
            return new ImportContainerCreatedEventQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ImportContainerCreatedEventQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ImportContainerCreatedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ImportContainerCreatedEventQueryBuilderDsl>(p, ImportContainerCreatedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportContainerCreatedEventQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<ImportContainerCreatedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<ImportContainerCreatedEventQueryBuilderDsl>(p, ImportContainerCreatedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportContainerCreatedEventQueryBuilderDsl, string> ResourceType()
        {
            return new ComparisonPredicateBuilder<ImportContainerCreatedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceType")),
            p => new CombinationQueryPredicate<ImportContainerCreatedEventQueryBuilderDsl>(p, ImportContainerCreatedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportContainerCreatedEventQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ImportContainerCreatedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ImportContainerCreatedEventQueryBuilderDsl>(p, ImportContainerCreatedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportContainerCreatedEventQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ImportContainerCreatedEventQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ImportContainerCreatedEventQueryBuilderDsl>(p, ImportContainerCreatedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ImportContainerCreatedEventQueryBuilderDsl> Data(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.ImportContainerCreatedEventDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.ImportContainerCreatedEventDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ImportContainerCreatedEventQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("data"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.ImportContainerCreatedEventDataQueryBuilderDsl.Of())),
                ImportContainerCreatedEventQueryBuilderDsl.Of);
        }


    }
}
