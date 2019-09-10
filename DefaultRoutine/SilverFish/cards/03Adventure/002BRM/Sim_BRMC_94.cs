using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._03Adventure._002BRM
{
	class Sim_BRMC_94 : SimTemplate //* Sulfuras
	{
		// Deathrattle:: Your Hero Power becomes 'Deal 8 damage to a random enemy'.
		
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardIdEnum.BRMC_94);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.setNewHeroPower(CardIdEnum.BRM_027p, m.own); // DIE, INSECT!
        }
    }
}