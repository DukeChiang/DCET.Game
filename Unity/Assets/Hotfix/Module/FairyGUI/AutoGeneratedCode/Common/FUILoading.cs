/** This is an automatically generated class by FairyGUI plugin FGUI2ET. Please do not modify it. **/

using System.Threading.Tasks;
using FairyGUI;
using ETModel;
using ETHotfix;

namespace ETHotfix.Common
{
    [ObjectSystem]
    public class FUILoadingAwakeSystem : AwakeSystem<FUILoading, GObject>
    {
        public override void Awake(FUILoading self, GObject go)
        {
            self.Awake(go);
        }
    }
	
	public sealed class FUILoading : FUI
	{	
		public const string UIPackageName = "Common";
		public const string UIResName = "Loading";
		
		/// <summary>
        /// Loading的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
		public GComponent self;
		
		public GImage bg;
		public GTextField loadingText;
		public FUILoadingProgressBar loadingBar;

		private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }
		
		private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUILoading CreateInstance()
		{			
			return ComponentFactory.Create<FUILoading, GObject>(CreateGObject());
		}

        public static Task<FUILoading> CreateInstanceAsync()
        {
            TaskCompletionSource<FUILoading> tcs = new TaskCompletionSource<FUILoading>();

            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(ComponentFactory.Create<FUILoading, GObject>(go));
            });

            return tcs.Task;
        }

        public static FUILoading Create(GObject go)
		{
			return ComponentFactory.Create<FUILoading, GObject>(go);
		}
		
        /// <summary>
        /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static FUILoading GetFormPool(GObject go)
        {
            var fui = go.Get<FUILoading>();

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
			
			self = (GComponent)go;
			
			self.Add(this);
			
			var com = go.asCom;
				
			if(com != null)
			{	
				bg = (GImage)com.GetChild("bg");
				loadingText = (GTextField)com.GetChild("loadingText");
				loadingBar = FUILoadingProgressBar.Create(com.GetChild("loadingBar"));
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
			loadingText = null;
			loadingBar.Dispose();
			loadingBar = null;
		}
	}
}