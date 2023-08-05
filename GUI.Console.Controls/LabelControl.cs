namespace GUI.Console.Controls
{
    public class LabelControl : Control
    {
        public string Text { get; set; }

        public LabelControl(params Control[] children)
            : base(children)
        {
        }
    }
}
