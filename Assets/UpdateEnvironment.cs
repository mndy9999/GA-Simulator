using System.Collections;
using System.Collections.Generic;
using Polarith.AI.Move;
using UnityEngine;

public class UpdateEnvironment : MonoBehaviour {

    public AIMEnvironment Environment;

	
	// Update is called once per frame
	void Update () {
        Environment.UpdateLayerGameObjects();
	}
}
