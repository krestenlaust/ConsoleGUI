namespace GUI {
    public abstract class LayoutControl : Control
    {
        public LayoutControl(params Control[] children)
            : base(children)
        {
        }

        public abstract Vector GetChildControlOffset(Control control);
    }
}