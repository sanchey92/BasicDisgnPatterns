using Autofac;
using Autofac.Features.Metadata;
using DotnetDesignPatterns.Structural.Adapter.AdapterDI;

namespace DotnetDesignPatterns.Structural.Adapter
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var b = new ContainerBuilder();
            
            b.RegisterType<OpenCommand>()
                .As<ICommand>()
                .WithMetadata("Name", "Open");
            
            b.RegisterType<SaveCommand>()
                .As<ICommand>()
                .WithMetadata("Name", "Save");
            
            // b.RegisterType<Button>();
            b.RegisterAdapter<Meta<ICommand>, Button>(cmd =>
                new Button(cmd.Value, (string) cmd.Metadata["Name"]));
            
            b.RegisterType<Editor>();

            using var c = b.Build();
            var editor = c.Resolve<Editor>();
            editor.ClickAll();

            foreach (var button in editor.Buttons)
            {
                button.PrintMe();
            }
        }
    }
}