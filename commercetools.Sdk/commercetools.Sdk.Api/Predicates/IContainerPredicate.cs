namespace commercetools.Sdk.Api.Predicates
{
    public interface IContainerPredicate<out T> : IPredicate where T : IPredicate
    {
        public T Parent();

        public T Inner();

        public bool RenderInnerWithOutParentheses();
    }
}