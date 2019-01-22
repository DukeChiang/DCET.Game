using BehaviorDesigner.Runtime;
using ETModel;

namespace ETHotfix
{
    [ObjectSystem]
    public class BehaviorManagerComponentUpdateSystem : UpdateSystem<BehaviorManagerComponent>
    {
        public override void Update(BehaviorManagerComponent self)
        {
            BehaviorManager.instance?.Update();
        }
    }

    [ObjectSystem]
    public class BehaviorManagerComponentLateUpdateSystem : LateUpdateSystem<BehaviorManagerComponent>
    {
        public override void LateUpdate(BehaviorManagerComponent self)
        {
            BehaviorManager.instance?.LateUpdate();
        }
    }

    [ObjectSystem]
    public class BehaviorManagerComponentFixedUpdateSystem : FixedUpdateSystem<BehaviorManagerComponent>
    {
        public override void FixedUpdate(BehaviorManagerComponent self)
        {
            BehaviorManager.instance?.FixedUpdate();
        }
    }
}
