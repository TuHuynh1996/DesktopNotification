namespace DesktopToast
{
	//
	// Summary:
	//     Contains state information and event of Onactivate Toast Click.
	public class ToastClickEventArgs
	{
		/// <summary>
		/// Toast information
		/// </summary>
		public string UserModelId { get; set; }

		/// <summary>
		/// Action hander of the button click
		/// </summary>
		public string Action { get; set; }
	}
}
