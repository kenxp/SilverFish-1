﻿using Chuck.SilverFish;

namespace SilverFish.cards._01Basic._04Paladin
{
    class Sim_CS2_092 : SimTemplate//blessing of kings
    {

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetBuffed(target, 4, 4);
        }

    }
}
