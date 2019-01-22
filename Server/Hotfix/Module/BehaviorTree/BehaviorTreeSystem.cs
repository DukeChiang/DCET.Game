using BehaviorDesigner.Runtime;
using ETModel;

namespace ETHotfix
{
    [ObjectSystem]
    public class BehaviorTreeAwakeSystem : AwakeSystem<BehaviorTree, Behavior>
    {
        public override void Awake(BehaviorTree self, Behavior behavior)
        {
            self.Behavior = behavior;
        }
    }
}
