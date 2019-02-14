using ETHotfix.Common;
using ETModel;

namespace ETHotfix
{
    [Event(EventIdType.InitSceneStart)]
	public class InitSceneStart_CreateLoadingUI : AEvent
	{
        public override void Run()
        {
            var fui = FUILoading.CreateInstance();
            fui.MakeFullScreen();
            Game.Scene.GetComponent<FUIComponent>().Add(fui);
        }
    }
}