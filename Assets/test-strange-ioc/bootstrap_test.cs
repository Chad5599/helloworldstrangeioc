using System;

using UnityEngine;

using strange.extensions.context.impl;

namespace Game {
	
public class bootstrap_test :  ContextView  {



	void Awake() {
		this.context = new testContext(this);

	}
	
  }

}