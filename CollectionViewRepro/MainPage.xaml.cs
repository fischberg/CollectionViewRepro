namespace CollectionViewRepro;

public partial class MainPage : ContentPage
{
	private CollectionViewData vm { get; set; }

	public MainPage()
	{
		vm = new CollectionViewData();
		InitializeComponent();
		BindingContext = vm;
	}
}


