﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVVV.PluginInterfaces.V2.NonGeneric;

namespace VVVV.Pack.Game
{
    public static class SpreadUtils
    {
        public static bool IsAnyInvalid(this ISpread spread, params ISpread[] spreads)
        {
            if (spread.SliceCount == 0 || spread[0] == null) return true;
            else
            {
                for (int i = 0; i < spreads.Length; i++)
                {
                    if (spreads[i].SliceCount == 0 || spreads[i][0] == null) return true;
                }
            }

            return false;
        }
    }
}