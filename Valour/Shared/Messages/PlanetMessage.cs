﻿using Newtonsoft.Json;
using System.Collections.Generic;
using Valour.Shared.Users;

/*  Valour - A free and secure chat client
 *  Copyright (C) 2021 Vooper Media LLC
 *  This program is subject to the GNU Affero General Public license
 *  A copy of the license should be included - if not, see <http://www.gnu.org/licenses/>
 */

namespace Valour.Shared.Messages
{
    public class PlanetMessage : Message
    {
        //[JsonProperty("p")]
        public ulong Planet_Id { get; set; }

        public ulong Member_Id { get; set; }
    }
}
