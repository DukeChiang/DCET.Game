using System;
using BehaviorDesigner.Runtime;
using ETModel;

namespace ETHotfix
{
	public static class Init
	{
		public async static void Start()
		{
			try
			{
				Game.Scene.ModelScene = ETModel.Game.Scene;

				// 注册热更层回调
				ETModel.Game.Hotfix.Update = () => { Update(); };
				ETModel.Game.Hotfix.LateUpdate = () => { LateUpdate(); };
				ETModel.Game.Hotfix.OnApplicationQuit = () => { OnApplicationQuit(); };

                Game.Scene.AddComponent<OpcodeTypeComponent>();
				Game.Scene.AddComponent<MessageDispatherComponent>();

				// 加载热更配置
				ETModel.Game.Scene.GetComponent<ResourcesComponent>().LoadBundle("config.unity3d");
				Game.Scene.AddComponent<ConfigComponent>();
				ETModel.Game.Scene.GetComponent<ResourcesComponent>().UnloadBundle("config.unity3d");

                Game.Scene.AddComponent<BehaviorTreeComponent, BehaviorTree>(UnityEngine.GameObject.Find("Cube").GetComponent<BehaviorTree>());
                
                Game.Scene.AddComponent<FUIComponent>();

                await Game.Scene.AddComponent<FUIInitComponent>().Init();

                Game.EventSystem.Run(EventIdType.InitSceneStart);
            }
            catch (Exception e)
			{
				Log.Error(e);
			}
		}

        public static void FixedUpdate()
        {
            try
            {
                Game.EventSystem.FixedUpdate();
            }
            catch (Exception e)
            {
                Log.Error(e);
            }
        }

        public static void Update()
		{
			try
			{
				Game.EventSystem.Update();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		public static void LateUpdate()
		{
			try
			{
				Game.EventSystem.LateUpdate();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		public static void OnApplicationQuit()
		{
			Game.Close();
		}
	}
}