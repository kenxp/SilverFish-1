using Chuck.SilverFish;

namespace SilverFish.cards._04Expansion._005UNG
{
	class Sim_UNG_829 : SimTemplate //* Lakkari Sacrifice
	{
		//Quest: Discard 6 cards. Reward: Nether Portal.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 2) p.evaluatePenality -= 30;
        }
    }
}