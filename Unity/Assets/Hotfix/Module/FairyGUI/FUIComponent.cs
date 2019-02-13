using ETModel;
using FairyGUI;
using System.Collections.Generic;

namespace ETHotfix
{
	[ObjectSystem]
	public class FUIComponentAwakeSystem : AwakeSystem<FUIComponent>
	{
		public override void Awake(FUIComponent self)
		{
			self.Root = ComponentFactory.Create<FUI, GObject>(GRoot.inst);
		}
	}

	/// <summary>
	/// 管理所有顶层UI, 顶层UI都是GRoot的孩子
	/// </summary>
	public class FUIComponent: Component
	{
		public FUI Root;
		
		public override void Dispose()
		{
			if (IsDisposed)
			{
				return;
			}

			base.Dispose();

            Root.Dispose();
            Root = null;
		}

		public void Add(FUI ui)
		{
			Root.Add(ui);
		}
		
		public void Remove(long id)
		{
			Root.Remove(id);
		}
		
		public FUI Get(long id)
		{
			FUI ui = Root.Get(id);
			return ui;
		}

        public List<T> GetAll<T>() where T : FUI
        {
            return Root.GetAll<T>();
        }
	}
}