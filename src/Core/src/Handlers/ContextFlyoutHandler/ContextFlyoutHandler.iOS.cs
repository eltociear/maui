using System;
using UIKit;

namespace Microsoft.Maui.Handlers
{
	[System.Runtime.Versioning.SupportedOSPlatform("ios13.0")]
	public partial class ContextFlyoutHandler : ElementHandler<IContextFlyout, UIMenu>, IContextFlyoutHandler
	{
		protected override UIMenu CreatePlatformElement()
		{
			var platformMenu =
				VirtualView
					.ToPlatformMenu(MauiContext!);
			return platformMenu;
		}

		public void Add(IMenuElement view)
		{
			Rebuild();
		}

		public void Remove(IMenuElement view)
		{
			Rebuild();
		}

		public void Clear()
		{
			Rebuild();
		}

		public void Insert(int index, IMenuElement view)
		{
			Rebuild();
		}

		internal static void Rebuild()
		{
			// TODO: This probably isn't right because we're not using the "global" context menu system
			// as far as I can tell. But this should instead remove any existing context menu interaction
			// and rebuild the context menu items?
			//UIMenuSystem
			//	.ContextSystem
			//	.SetNeedsRebuild();
		}
	}
}
