using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_383 : SimTemplate //tirionfordring
	{
        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardIdEnum.EX1_383t);
//    gottesschild/. spott/. todesröcheln:/ legt einen aschenbringer (5/3) an.

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.equipWeapon(card,m.own);
        }

	}
}