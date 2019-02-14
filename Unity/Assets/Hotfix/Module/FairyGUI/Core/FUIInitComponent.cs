using ETModel;
using System.Threading.Tasks;

namespace ETHotfix
{
	public class FUIInitComponent : Component
    {
        public async Task Init()
        {
            await ETModel.Game.Scene.GetComponent<FUIPackageComponent>().AddPackageAsync(FGUIPackage.Common);
        }

        public override void Dispose()
		{
			if (IsDisposed)
			{
				return;
			}

			base.Dispose();

            ETModel.Game.Scene.GetComponent<FUIPackageComponent>().RemovePackage(FGUIPackage.Common);
        }
    }
}