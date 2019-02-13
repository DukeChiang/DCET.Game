using ETModel;
using FairyGUI;
using System.Collections.Generic;
using System.Linq;

namespace ETHotfix
{
    [ObjectSystem]
	public class FUIAwakeSystem : AwakeSystem<FUI, GObject>
	{
		public override void Awake(FUI self, GObject gObject)
		{
			self.GObject = gObject;
		}
	}
	
	public class FUI: Entity
	{
		public GObject GObject;

        public string Name
        {
            get { return GObject?.displayObject?.name; }
        }

        private Dictionary<long, FUI> children = new Dictionary<long, FUI>();

		public bool IsWindow
		{
			get
			{
				return GObject is GWindow;
			}
		}

        protected bool isFromFGUIPool = false;
		
		public override void Dispose()
		{
			if (IsDisposed)
			{
				return;
			}
			
			base.Dispose();
			
			// 从父亲中删除自己
			GetParent<FUI>()?.RemoveNoDispose(Id);

			// 删除所有的孩子
			foreach (FUI ui in children.Values.ToList())
			{
				ui.Dispose();
			}

			children.Clear();

            // 删除自己的UI
            if (!(GObject is GRoot) && !isFromFGUIPool)
            {
                GObject.Dispose();
            }

            GObject = null;
            isFromFGUIPool = false;
        }

		public void Add(FUI ui)
		{
            if(ui != null && ui.GObject != null && GObject is GComponent)
            {
                children.Add(ui.Id, ui);
                
                (GObject as GComponent).AddChild(ui.GObject);

                ui.Parent = this;
            }
		}

        public void MakeFullScreen()
        {
            if (GObject != null && GObject is GComponent)
            {
                (GObject as GComponent).MakeFullScreen();
            }
        }

		public void Remove(long id)
		{
			if (IsDisposed)
			{
				return;
			}

			FUI ui;

			if (children.TryGetValue(id, out ui))
            {
                children.Remove(id);

                if (ui != null && GObject is GComponent)
                {
                    (GObject as GComponent).RemoveChild(ui.GObject, false);
                }
                
                if (ui != null)
                {
                    ui.Parent = null;
                    ui.Dispose();
                }
            }
		}

        /// <summary>
        /// 一般情况不要使用此方法，如需使用，需要自行管理返回值的FUI的释放。
        /// </summary>
        public FUI RemoveNoDispose(long id)
        {
            if (IsDisposed)
            {
                return null;
            }

            FUI ui;

            if (children.TryGetValue(id, out ui))
            {
                children.Remove(id);

                if (ui != null)
                {
                    if(GObject is GComponent)
                    {
                        (GObject as GComponent).RemoveChild(ui.GObject, false);
                    }
                    ui.Parent = null;
                }
            }

            return ui;
        }

        public void RemoveChildren()
		{
			foreach (var child in children.Values.ToArray())
			{
				child.Dispose();
			}

			children.Clear();
		}

		public FUI Get(long id)
		{
			FUI child;

			if (children.TryGetValue(id, out child))
			{
				return child;
			}
			
			return null;
		}

        public List<T> GetAll<T>() where T : FUI
        {
            var result = new List<T>();

            foreach (var item in children)
            {
                if(item.Value is T)
                {
                    result.Add(item.Value as T);
                }
            }

            return result;
        }

        public bool Visible
		{
			get
			{
				return GObject.visible;
			}
			set
			{
				GObject.visible = value;
			}
		}
    }
}