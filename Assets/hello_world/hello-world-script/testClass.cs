using System;

using UnityEngine;

using strange.extensions.context.impl;
using strange.extensions.command.api;
using strange.extensions.command.impl;
using strange.extensions.signal.impl;

namespace Game {
	public class testClass : MVCSContext{

		public void Start()
		{

			Signal startSignal = injectionBinder.GetInstance<StartSignal>();
			startSignal.Dispatch();
			startSignal.Dispatch();
			startSignal.Dispatch();
			startSignal.Dispatch();
		}

	

	}
}