using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class ImportValidationFailedEventQueryBuilderDsl
    {
        public ImportValidationFailedEventQueryBuilderDsl()
        {
        }

        public static ImportValidationFailedEventQueryBuilderDsl Of()
        {
            return new ImportValidationFailedEventQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ImportValidationFailedEventQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ImportValidationFailedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ImportValidationFailedEventQueryBuilderDsl>(p, ImportValidationFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportValidationFailedEventQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<ImportValidationFailedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<ImportValidationFailedEventQueryBuilderDsl>(p, ImportValidationFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportValidationFailedEventQueryBuilderDsl, string> ResourceType()
        {
            return new ComparisonPredicateBuilder<ImportValidationFailedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceType")),
            p => new CombinationQueryPredicate<ImportValidationFailedEventQueryBuilderDsl>(p, ImportValidationFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportValidationFailedEventQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ImportValidationFailedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ImportValidationFailedEventQueryBuilderDsl>(p, ImportValidationFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportValidationFailedEventQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ImportValidationFailedEventQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ImportValidationFailedEventQueryBuilderDsl>(p, ImportValidationFailedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ImportValidationFailedEventQueryBuilderDsl> Data(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.ImportValidationFailedEventDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.ImportValidationFailedEventDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ImportValidationFailedEventQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("data"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.ImportValidationFailedEventDataQueryBuilderDsl.Of())),
                ImportValidationFailedEventQueryBuilderDsl.Of);
        }


    }
}
