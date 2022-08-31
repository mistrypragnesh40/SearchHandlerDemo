using SearchHandlerDemo.ViewModels;

namespace SearchHandlerDemo.Views;

public partial class StudentDetailView : ContentPage
{
	public StudentDetailView()
	{
		InitializeComponent();
		this.BindingContext = new StudentDetailViewModel();
	}
}