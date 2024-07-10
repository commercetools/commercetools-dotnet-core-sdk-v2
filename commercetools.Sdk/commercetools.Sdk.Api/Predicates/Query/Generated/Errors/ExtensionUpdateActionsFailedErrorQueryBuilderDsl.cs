using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ExtensionUpdateActionsFailedErrorQueryBuilderDsl
    {
        public ExtensionUpdateActionsFailedErrorQueryBuilderDsl()
        {
        }

        public static ExtensionUpdateActionsFailedErrorQueryBuilderDsl Of()
        {
            return new ExtensionUpdateActionsFailedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionUpdateActionsFailedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ExtensionUpdateActionsFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ExtensionUpdateActionsFailedErrorQueryBuilderDsl>(p, ExtensionUpdateActionsFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionUpdateActionsFailedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ExtensionUpdateActionsFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ExtensionUpdateActionsFailedErrorQueryBuilderDsl>(p, ExtensionUpdateActionsFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExtensionUpdateActionsFailedErrorQueryBuilderDsl> LocalizedMessage(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionUpdateActionsFailedErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("localizedMessage"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ExtensionUpdateActionsFailedErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ExtensionUpdateActionsFailedErrorQueryBuilderDsl, string> ExtensionExtraInfo()
        {
            return new ComparisonPredicateBuilder<ExtensionUpdateActionsFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionExtraInfo")),
            p => new CombinationQueryPredicate<ExtensionUpdateActionsFailedErrorQueryBuilderDsl>(p, ExtensionUpdateActionsFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExtensionUpdateActionsFailedErrorQueryBuilderDsl> ExtensionErrors(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionUpdateActionsFailedErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("extensionErrors"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionErrorQueryBuilderDsl.Of())),
                ExtensionUpdateActionsFailedErrorQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ExtensionUpdateActionsFailedErrorQueryBuilderDsl> ExtensionErrors()
        {
            return new CollectionPredicateBuilder<ExtensionUpdateActionsFailedErrorQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionErrors")),
                    p => new CombinationQueryPredicate<ExtensionUpdateActionsFailedErrorQueryBuilderDsl>(p, ExtensionUpdateActionsFailedErrorQueryBuilderDsl.Of));
        }

    }
}
