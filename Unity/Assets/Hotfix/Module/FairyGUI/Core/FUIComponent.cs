using ETModel;
using FairyGUI;

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
		
		public void Remove(string name)
		{
			Root.Remove(name);
		}
		
		public FUI Get(string name)
		{
			FUI ui = Root.Get(name);
			return ui;
		}

        public FUI[] GetAll()
        {
            return Root.GetAll();
        }
	}
}