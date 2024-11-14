using CollectionNameStudent.Services;
using CollectionNameStudent.ViewModels;

namespace CollectionNameStudent;

public partial class StudentPage : ContentPage
{
	public StudentPage()
	{
		InitializeComponent();
		var firestoreService = new FirestoreService();
		BindingContext = new StudentViewModel(firestoreService);
	}
}