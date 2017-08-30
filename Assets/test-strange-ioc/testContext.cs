using System;

using UnityEngine;

using strange.extensions.context.impl;

namespace Game {
	public class testContext : SignalContext {

		public testContext(MonoBehaviour contextView) : base(contextView) {
		}
	
		protected override void mapBindings() {
			base.mapBindings();

		
			commandBinder.Bind<StartSignal>().To<testCommand>();
	

		}

	}
}


