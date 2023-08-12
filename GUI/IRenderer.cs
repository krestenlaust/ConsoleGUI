namespace GUI
{
    public interface IRenderer<in T>
        where T : Control
    {
        void RenderScreen();
    }
}
