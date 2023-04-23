using CommunityToolkit.Mvvm.ComponentModel;

namespace CollectionViewRepro
{
	public partial class CollectionViewData : ObservableObject
	{
		public List<string> CollectionViewElements { get; private set; }

		[ObservableProperty]
		private string selected;

		public CollectionViewData()
		{
			CollectionViewElements = new()
			{
				" 1 ",
				" 2 ",
				" 3 "
			};

			Selected = CollectionViewElements[1];
		}
	}
}
