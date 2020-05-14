<<<<<<< HEAD
﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System;
=======
﻿using System;
>>>>>>> 4e7bd2fe10749d646c1ebc3b8f87df254d7d14fe
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MixedRealityExtension.App;
using MixedRealityExtension.Messaging.Payloads;
using MixedRealityExtension.Patching.Types;

namespace MixedRealityExtension.Messaging.Events.Types
{
	internal class PhysicsBridgeUpdated : MWEventBase
	{
		private readonly PhysicsBridgePatch _physicsBridgePatch;


		public PhysicsBridgeUpdated(Guid id, PhysicsBridgePatch physicsBridgePatch) 
			: base(id)
		{
			_physicsBridgePatch = physicsBridgePatch;
		}

		internal override void SendEvent(MixedRealityExtensionApp app)
		{
			if (app.Protocol == null)
			{
				return;
			}

			app.Protocol.Send(new PhysicsBridgeUpdate()
			{
				PhysicsBridge = _physicsBridgePatch
			});
		}
	}
}
