using ETModel;

namespace ETHotfix
{
    // 分发数值监听
    [Event(EventIdType.TestBehavior)]
    public class TestBehavior_RunHandler : AEvent<string>
    {
        public override void Run(string name)
        {
            BehaviorTreeFactory.Create(name);
        }
    }
}
