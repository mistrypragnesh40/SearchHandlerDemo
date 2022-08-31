using SearchHandlerDemo.ViewModels;

namespace SearchHandlerDemo.Views;

public partial class StudentListView : ContentPage
{
	public StudentListView()
	{
		InitializeComponent();
		this.BindingContext = new StudentListViewModel();
	}
}