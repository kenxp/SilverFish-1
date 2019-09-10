using Chuck.SilverFish;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_tk9 : SimTemplate //treant
	{

//    ansturm/. vernichtet diesen diener am ende des zuges.


        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == triggerEffectMinion.own)
            {
                p.minionGetDestroyed(triggerEffectMinion);
            }
        }

	}
}