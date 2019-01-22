using BehaviorDesigner.Runtime.Tasks;
using ETModel;
using System.Collections.Generic;

namespace ETHotfix
{
    public class BehaviorTreeComponent : Component
    {
        public BehaviorTree BehaviorTree;
        public Dictionary<HotfixAction, Component> ActionComponents = new Dictionary<HotfixAction, Component>();
        public Dictionary<HotfixComposite, Component> CompositeComponents = new Dictionary<HotfixComposite, Component>();
        public Dictionary<HotfixConditional, Component> ConditionalComponents = new Dictionary<HotfixConditional, Component>();
        public Dictionary<HotfixDecorator, Component> DecoratorComponents = new Dictionary<HotfixDecorator, Component>();

        public override void Dispose()
        {
            if (IsDisposed)
            {
                return;
            }

            base.Dispose();

            foreach(var item in ActionComponents)
            {
                item.Value.Dispose();
            }

            ActionComponents.Clear();

            foreach (var item in CompositeComponents)
            {
                item.Value.Dispose();
            }

            CompositeComponents.Clear();

            foreach (var item in ConditionalComponents)
            {
                item.Value.Dispose();
            }

            ConditionalComponents.Clear();

            foreach (var item in DecoratorComponents)
            {
                item.Value.Dispose();
            }

            DecoratorComponents.Clear();

            BehaviorTree = null;
        }
    }
}