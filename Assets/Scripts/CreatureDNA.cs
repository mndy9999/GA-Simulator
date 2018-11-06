using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureDNA : MonoBehaviour {

    List <string> traits = new List<string>(){
        "SPEED",
        "STRENGTH",
        "SIGTH",
        "FERTILITY",
        "HEARING",
        "SMELLING"
    };
    
    float[] traitsArr;

    bool swim;
    bool fishing;
    bool collecting;
    bool digging;

    //to do: add more characteristics eg. cold/heat resitance

	// Use this for initialization
	void Start () {
        traitsArr = new float[6];
        for(int i = 0; i < 6; i++)
        {
            traitsArr[i] = Random.Range(0, 5);
            Debug.Log(traits[i]+": " + traitsArr[i]);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
