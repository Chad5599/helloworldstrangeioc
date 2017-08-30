using System;

using UnityEngine;

using System;

using UnityEngine;

using strange.extensions.mediation.impl;

namespace Game {
	public class HelloWorldMediator : Mediator {

		[Inject]
		public HelloWorldView view {get; set;}

		[Inject]
		public DoManagementSignal doManagement {get; set;}

		public override void OnRegister() {
			Debug.Log("start 2");
			view.buttonClicked.AddListener(doManagement.Dispatch);

		}

	}
}