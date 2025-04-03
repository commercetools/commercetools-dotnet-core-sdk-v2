using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class ImportUnresolvedEventQueryBuilderDsl
    {
        public ImportUnresolvedEventQueryBuilderDsl()
        {
        }

        public static ImportUnresolvedEventQueryBuilderDsl Of()
        {
            return new ImportUnresolvedEventQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ImportUnresolvedEventQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ImportUnresolvedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ImportUnresolvedEventQueryBuilderDsl>(p, ImportUnresolvedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportUnresolvedEventQueryBuilderDsl, string> NotificationType()
        {
            return new ComparisonPredicateBuilder<ImportUnresolvedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("notificationType")),
            p => new CombinationQueryPredicate<ImportUnresolvedEventQueryBuilderDsl>(p, ImportUnresolvedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportUnresolvedEventQueryBuilderDsl, string> ResourceType()
        {
            return new ComparisonPredicateBuilder<ImportUnresolvedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceType")),
            p => new CombinationQueryPredicate<ImportUnresolvedEventQueryBuilderDsl>(p, ImportUnresolvedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportUnresolvedEventQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ImportUnresolvedEventQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ImportUnresolvedEventQueryBuilderDsl>(p, ImportUnresolvedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportUnresolvedEventQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ImportUnresolvedEventQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ImportUnresolvedEventQueryBuilderDsl>(p, ImportUnresolvedEventQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ImportUnresolvedEventQueryBuilderDsl> Data(
            Func<commercetools.Sdk.Api.Predicates.Query.Events.ImportUnresolvedEventDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Events.ImportUnresolvedEventDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ImportUnresolvedEventQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("data"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Events.ImportUnresolvedEventDataQueryBuilderDsl.Of())),
                ImportUnresolvedEventQueryBuilderDsl.Of);
        }


    }
}
