using GUI.Console.Controls;

namespace ApiDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var form1 = new GroupControl();

            var subForm1 = new GroupControl(
                        new LabelControl()
                        );

            var subForm2 = new GroupControl(
                        new LabelControl()
                        );
        }
    }
}