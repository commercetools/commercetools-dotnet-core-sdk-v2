using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class ImportWaitForMasterVariantEventQueryBuilderDsl
    {
        public ImportWaitForMasterVariantEventQueryBuilderDsl()
        {
        }

        public static ImportWaitForMasterVariantEventQueryBuilderDsl Of()
        {
            return new ImportWaitForMasterVariantEventQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ImportWaitForMasterVariantEventQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ImportWaitForMasterVariantEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ImportWaitForMasterVariantEventQueryBuilderDsl>(p, ImportWaitForMasterVariantEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportWaitForMasterVariantEventQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<ImportWaitForMasterVariantEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<ImportWaitForMasterVariantEventQueryBuilderDsl>(p, ImportWaitForMasterVariantEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportWaitForMasterVariantEventQueryBuilderDsl, string> ResourceType()
        {
            return new ComparisonPredicateBuilder<ImportWaitForMasterVariantEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceType")),
            p => new CombinationQueryPredicate<ImportWaitForMasterVariantEventQueryBuilderDsl>(p, ImportWaitForMasterVariantEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportWaitForMasterVariantEventQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ImportWaitForMasterVariantEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ImportWaitForMasterVariantEventQueryBuilderDsl>(p, ImportWaitForMasterVariantEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportWaitForMasterVariantEventQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ImportWaitForMasterVariantEventQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ImportWaitForMasterVariantEventQueryBuilderDsl>(p, ImportWaitForMasterVariantEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ImportWaitForMasterVariantEventQueryBuilderDsl> Data(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.ImportWaitForMasterVariantEventDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.ImportWaitForMasterVariantEventDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ImportWaitForMasterVariantEventQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("data"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.ImportWaitForMasterVariantEventDataQueryBuilderDsl.Of())),
                ImportWaitForMasterVariantEventQueryBuilderDsl.Of);
        }


    }
}
