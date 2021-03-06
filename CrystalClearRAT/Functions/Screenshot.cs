﻿using CrystalRATShared.Commands;
using CrystalRATShared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalClearRAT.Functions
{
    public static class Screenshot
    {
        public static byte[] Request(string identifier)
        {
            return CommandDataSerializer.Serialize(CommandFlags.Screenshot, (writer) => { writer.Write(identifier); });
        }
    }
}
