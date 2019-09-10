using Chuck.SilverFish;

namespace SilverFish.cards._03Adventure._003LOE
{
	class Sim_LOE_113 : SimTemplate //* Everyfin is Awesome
	{
		//Give your minions +2/+2. Costs (1) less for each murloc you control.
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.allMinionOfASideGetBuffed(ownplay, 2, 2);
		}
	}
}