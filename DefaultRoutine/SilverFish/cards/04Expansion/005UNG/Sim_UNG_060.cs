using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._04Expansion._005UNG
{
	class Sim_UNG_060 : SimTemplate //* Mimic Pod
	{
		//Draw a card, then add a copy of it to your hand.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardName.unknown, ownplay);
            p.drawACard(CardName.unknown, ownplay, true);
		}
	}
}