/** This is an automatically generated class by FairyGUI plugin FGUI2ET. Please do not modify it. **/

using System.Threading.Tasks;
using FairyGUI;
using ETModel;
using ETHotfix;

namespace ETHotfix.Common
{
    [ObjectSystem]
    public class FUILoadingProgressBarAwakeSystem : AwakeSystem<FUILoadingProgressBar, GObject>
    {
        public override void Awake(FUILoadingProgressBar self, GObject go)
        {
            self.Awake(go);
        }
    }
	
	public sealed class FUILoadingProgressBar : FUI
	{	
		public const string UIPackageName = "Common";
		public const string UIResName = "LoadingProgressBar";
		
		/// <summary>
        /// LoadingProgressBar的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
		public GProgressBar self;
		
		public GImage bg;
		public GImage bar;

		private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }
		
		private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUILoadingProgressBar CreateInstance()
		{			
			return ComponentFactory.Create<FUILoadingProgressBar, GObject>(CreateGObject());
		}

        public static Task<FUILoadingProgressBar> CreateInstanceAsync()
        {
            TaskCompletionSource<FUILoadingProgressBar> tcs = new TaskCompletionSource<FUILoadingProgressBar>();

            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(ComponentFactory.Create<FUILoadingProgressBar, GObject>(go));
            });

            return tcs.Task;
        }

        public static FUILoadingProgressBar Create(GObject go)
		{
			return ComponentFactory.Create<FUILoadingProgressBar, GObject>(go);
		}
		
        /// <summary>
        /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static FUILoadingProgressBar GetFormPool(GObject go)
        {
            var fui = go.Get<FUILoadingProgressBar>();

            if(fui == null)
            {
                fui = Create(go);
            }

            fui.isFromFGUIPool = true;

            return fui;
        }
						
		public void Awake(GObject go)
		{
			if(go == null)
			{
				return;
			}
			
			GObject = go;	
			
			if (string.IsNullOrWhiteSpace(Name))
            {
				Name = Id.ToString();
            }
			
			self = (GProgressBar)go;
			
			self.Add(this);
			
			var com = go.asCom;
				
			if(com != null)
			{	
				bg = (GImage)com.GetChild("bg");
				bar = (GImage)com.GetChild("bar");
			}
		}
		
		public override void Dispose()
		{
			if(IsDisposed)
			{
				return;
			}
			
			base.Dispose();
			
			self.Remove();
			self = null;
			bg = null;
			bar = null;
		}
	}
}