using UI;
using UI.Console;
using UI.Console.Controls;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UI.Console.Windows;

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
            builder.Services.AddTransient<IRenderer<ConsoleControl>, ConsoleRenderer>();
            builder.Services.AddTransient<IInputHandler, InputHandler>();
            host = builder.Build();

            // Start application
            var manager = new UIManager<ConsoleControl>(
                host.Services.GetRequiredService<IRenderer<ConsoleControl>>(),
                host.Services.GetRequiredService<IInputHandler>());
        }

        static Control InstantiateUI()
        {
            GroupControl main = new GroupControl();

            main.AddControl(new LabelControl());


            return main;
        }
    }
}
