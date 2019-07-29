using System;
using System.Collections.Generic;
using System.Text;

namespace ForTests
{
    [System.Flags]
    public enum WondersOfTheAncientWorld : byte
    {
        GreatPiramidOfGiza = 1,
        HangingGardensOfBabylon = 1 << 1, // means 2
        StatueOfZeusAtOlympia = 1 << 2, // means 4
        TempleOfArtemisAtEphesus = 1 << 3, // means 8
        MausoleumAtHalicarnassus = 1 << 4, // means 16
        ColossusOfRhodes = 1 << 5, // means 32
        LighthouseOfAlexandria = 1 << 6 // means 64
    }
}
