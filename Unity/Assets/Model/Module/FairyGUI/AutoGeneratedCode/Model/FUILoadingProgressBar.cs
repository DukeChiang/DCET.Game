/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ETModel.Model
{
	public partial class FUILoadingProgressBar : GProgressBar
	{
		public GImage bg;

		public const string URL = "ui://2w4fpdl4n8hd5";

		public static FUILoadingProgressBar CreateInstance()
		{
			return (FUILoadingProgressBar)UIPackage.CreateObject("Model","LoadingProgressBar");
		}

		public FUILoadingProgressBar()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			bg = (GImage)this.GetChild("bg");
		}
	}
}