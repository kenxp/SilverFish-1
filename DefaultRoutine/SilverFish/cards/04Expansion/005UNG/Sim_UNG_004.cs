using Chuck.SilverFish;

namespace SilverFish.cards._04Expansion._005UNG
{
	class Sim_UNG_004 : SimTemplate //* Dinosize
	{
		//Set a minion's Attack and Health to 10.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.minionSetAngrToX(target, 10);
			p.minionSetLifetoX(target, 10);
		}
	}
}