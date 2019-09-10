using Chuck.SilverFish;

namespace SilverFish.cards._02Classic
{
    class Sim_EX1_611 : SimTemplate //freezingtrap
    {
        //todo secret
        //    geheimnis:/ wenn ein feindlicher diener angreift, lasst ihn auf die hand seines besitzers zurückkehren. zusätzlich kostet er (2) mehr.

        public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
        {
            p.minionReturnToHand(target, !ownplay, 2);
            target.HealthPoints = -100;
        }

    }
}