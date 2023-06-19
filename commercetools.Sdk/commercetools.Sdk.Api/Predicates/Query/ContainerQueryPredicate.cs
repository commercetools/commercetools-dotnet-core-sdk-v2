namespace commercetools.Sdk.Api.Predicates.Query
{
    public class ContainerQueryPredicate : IContainerPredicate<IQueryPredicate>, IQueryPredicate
    {
        private readonly IQueryPredicate _parent;

        private readonly IQueryPredicate _inner;

        private readonly bool _renderInnerWithoutParentheses;

        public ContainerQueryPredicate()
        {
            this._parent = null;
            this._inner = null;
            this._renderInnerWithoutParentheses = false;
        }

        public ContainerQueryPredicate(IQueryPredicate parent, IQueryPredicate inner,
            bool renderInnerWithoutParentheses = false)
        {
            this._parent = parent;
            this._inner = inner;
            this._renderInnerWithoutParentheses = renderInnerWithoutParentheses;
        }

        public IQueryPredicate Parent()
        {
            return _parent;
        }

        public IQueryPredicate Inner()
        {
            return _inner;
        }

        public bool RenderInnerWithOutParentheses()
        {
            return _renderInnerWithoutParentheses;
        }

        public ContainerQueryPredicate Parent(IQueryPredicate parent)
        {
            return new ContainerQueryPredicate(parent, _inner, _renderInnerWithoutParentheses);

        }

        public ContainerQueryPredicate Inner(IQueryPredicate inner)
        {
            return new ContainerQueryPredicate(_parent, inner, _renderInnerWithoutParentheses);
        }

        public ContainerQueryPredicate RenderInnerWithOutParentheses(bool renderInnerWithoutParentheses)
        {
            return new ContainerQueryPredicate(_parent, _inner, renderInnerWithoutParentheses);
        }

        /**
         * Remove Parentheses from Inner if RenderInnerWithOutParentheses is true
         * @return expression result as string
         */
        public string Render()
        {
            return this.RenderInnerWithOutParentheses()
                ? $"{Parent()?.Render()} {Inner()?.Render()}".Trim()
                : $"{Parent()?.Render()}({Inner()?.Render()})".Trim();
        }

        public static ContainerQueryPredicate Of()
        {
            return new ContainerQueryPredicate();
        }
    }
}