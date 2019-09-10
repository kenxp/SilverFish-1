using System.Collections.Generic;
using Chuck.SilverFish;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_158 : SimTemplate //souloftheforest
	{

//    verleiht euren dienern „todesröcheln:/ ruft einen treant (2/2) herbei.“

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;

            foreach (Minion m in temp)
            {
                m.souloftheforest++;
            }
		}

	}
}