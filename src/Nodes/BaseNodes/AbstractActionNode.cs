using System.Collections.Generic;
using VVVV.Pack.Game.Core;

namespace VVVV.Pack.Game.Nodes
{
    public abstract class AbstractActionNode : AbstractBehaviorNode
    {

        protected abstract void Behave(IEnumerable<Agent> agents);

        public override void Evaluate(int SpreadMax)
        {
            Behave(FAgents);
            FinishEvaluation();
        }
    }
}