using SearchHandlerDemo.Views;

namespace SearchHandlerDemo;

public partial class AppShell : Shell
{
    public Dictionary<string, Type> Routes { get; set; } = new Dictionary<string, Type>();
    public AppShell()
    {
        InitializeComponent();

        Routes.Add(nameof(StudentDetailView), (typeof(StudentDetailView)));

        foreach (var route in Routes)
            Routing.RegisterRoute(route.Key, route.Value);

    }
}
