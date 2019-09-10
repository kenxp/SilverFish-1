using Chuck.SilverFish;

namespace SilverFish.cards._03Adventure._001NAX
{
	class Sim_NAX13_03 : SimTemplate //* Supercharge
	{
		// Give your minions +2 Health.
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.allMinionOfASideGetBuffed(ownplay, 0, 2);
		}
	}
}