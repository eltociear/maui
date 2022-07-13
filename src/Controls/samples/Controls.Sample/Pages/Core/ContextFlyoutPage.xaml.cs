using System;
using System.Diagnostics;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace Maui.Controls.Sample.Pages
{
	public partial class ContextFlyoutPage
	{
		public ContextFlyoutPage()
		{
			InitializeComponent();

			ImageContextCommand = new Command(
				execute: async (object arg) =>
				{
					await DisplayAlert(
						title: "Image",
						message: $"The image's context menu was clicked via a command with parameter: {arg}",
						cancel: "OK");
				});

			BindingContext = this;
		}

		public ICommand ImageContextCommand { get; init; }

		int count;

		private void Button_Clicked(object sender, EventArgs e)
		{
			count++;
			OnPropertyChanged(nameof(CounterValue));
		}

		private void OnIncrementMenuItemClicked(object sender, EventArgs e)
		{
			var menuItem = (MenuFlyoutItem)sender;
			var incrementAmount = int.Parse((string)menuItem.CommandParameter);
			count += incrementAmount;
			OnPropertyChanged(nameof(CounterValue));
		}

		public string CounterValue => count.ToString("N0");

		private async void OnEntryMenuItemClicked(object sender, EventArgs e)
		{
			await DisplayAlert(
				title: "Entry",
				message: $"The entry's context menu was clicked: {((MenuFlyoutItem)sender).Text}",
				cancel: "OK");
		}

		private async void OnImageContextClicked(object sender, EventArgs e)
		{
			await DisplayAlert(
				title: "Image",
				message: $"The image's context menu was clicked",
				cancel: "OK");
		}
	}
}
