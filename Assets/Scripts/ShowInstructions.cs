using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInstructions : MonoBehaviour {

    public GameObject instructions;
    private bool show = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void showInstructions()
    {
        if(!show)
        {
            instructions.SetActive(true);
            show = true;
        }
        else
        {
            instructions.SetActive(false);
            show = false;
        }
    }
}
