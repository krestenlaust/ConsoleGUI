using ConsoleGUI;
using GUI;
using GUI.Console;
using GUI.Console.Controls;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DemoProject
{
    internal class Program
    {
        static IHost host;

        static void Main(string[] args)
        {
            // Setup DI
            HostApplicationBuilder builder = Host.CreateApplicationBuilder();
            builder.Services.AddTransient<IConsole, ConsoleImpl>();
            builder.Services.AddTransient<IRenderer, ConsoleRenderer>();
            builder.Services.AddTransient<IInputHandler, InputHandler>();
            host = builder.Build();

            // Start application
            GUIManager manager = new GUIManager(
                host.Services.GetRequiredService<IRenderer>(),
                host.Services.GetRequiredService<IInputHandler>());
        }

        static Control InstantiateGUI()
        {
            GroupControl main = new GroupControl();

            main.AddControl(new LabelControl());


            return main;
        }
    }
}
