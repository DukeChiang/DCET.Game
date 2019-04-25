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

            //默认将会以Id为Name，也可以自定义Name，方便查询和管理
            fui.Name = FUILoading.UIResName;

            fui.MakeFullScreen();
            Game.Scene.GetComponent<FUIComponent>().Add(fui, true);
        }
    }
}