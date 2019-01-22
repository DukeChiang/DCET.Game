using BehaviorDesigner.Runtime.Tasks;
using ETModel;

namespace ETHotfix
{
    [ObjectSystem]
    public class BehaviorTreeComponentAwakeSystem : AwakeSystem<BehaviorTreeComponent, BehaviorTree>
    {
        public override void Awake(BehaviorTreeComponent self, BehaviorTree behaviorTree)
        {
            self.Awake(behaviorTree);
        }
    }

    public static class BehaviorTreeComponentSystem
    {
        public static void Awake(this BehaviorTreeComponent self, BehaviorTree behaviorTree)
        {
            if(behaviorTree == null || behaviorTree.Behavior == null)
            {
                return;
            }

            self.BehaviorTree = behaviorTree;

            behaviorTree.Behavior.StartWhenEnabled = false;
            behaviorTree.Behavior.ResetValuesOnRestart = false;

            BindHotfixActions(self, behaviorTree);
            BindHotfixComposites(self, behaviorTree);
            BindHotfixConditionals(self, behaviorTree);
            BindHotfixDecorators(self, behaviorTree);

            behaviorTree.Behavior.EnableBehavior();
        }

        private static void BindHotfixActions(BehaviorTreeComponent self, BehaviorTree behaviorTree)
        {
            var tasks = behaviorTree.Behavior.FindTasks<HotfixAction>();

            if(tasks == null)
            {
                return;
            }

            foreach (var hotfixAction in tasks)
            {
                var component = BehaviorTreeComponentFactory.Create(behaviorTree, hotfixAction);

                if (component != null)
                {
                    self.ActionComponents.Add(hotfixAction, component);
                }
            }
        }

        private static void BindHotfixComposites(BehaviorTreeComponent self, BehaviorTree behaviorTree)
        {
            var tasks = behaviorTree.Behavior.FindTasks<HotfixComposite>();

            if (tasks == null)
            {
                return;
            }

            foreach (var hotfixComposite in tasks)
            {
                var component = BehaviorTreeComponentFactory.Create(behaviorTree, hotfixComposite);

                if (component != null)
                {
                    self.CompositeComponents.Add(hotfixComposite, component);
                }
            }
        }

        private static void BindHotfixConditionals(BehaviorTreeComponent self, BehaviorTree behaviorTree)
        {
            var tasks = behaviorTree.Behavior.FindTasks<HotfixConditional>();

            if (tasks == null)
            {
                return;
            }

            foreach (var hotfixConditional in tasks)
            {
                var component = BehaviorTreeComponentFactory.Create(behaviorTree, hotfixConditional);

                if (component != null)
                {
                    self.ConditionalComponents.Add(hotfixConditional, component);
                }
            }
        }

        private static void BindHotfixDecorators(BehaviorTreeComponent self, BehaviorTree behaviorTree)
        {
            var tasks = behaviorTree.Behavior.FindTasks<HotfixDecorator>();

            if (tasks == null)
            {
                return;
            }

            foreach (var hotfixDecorator in tasks)
            {
                var component = BehaviorTreeComponentFactory.Create(behaviorTree, hotfixDecorator);

                if (component != null)
                {
                    self.DecoratorComponents.Add(hotfixDecorator, component);
                }
            }
        }

        public static void EnableBehaior(this BehaviorTreeComponent self)
        {
            self?.BehaviorTree?.Behavior?.EnableBehavior();
        }

        public static void DisableBehavior(this BehaviorTreeComponent self)
        {
            self?.BehaviorTree?.Behavior?.DisableBehavior();
        }
    }
}