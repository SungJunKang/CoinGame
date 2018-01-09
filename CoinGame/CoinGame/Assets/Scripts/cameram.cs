using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameram : MonoBehaviour {

    public static bool isMove=false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (isMove)
        {
            transform.Translate(new Vector3(0f, 0.01f, -0.004f));
            isMove = false;
        }
		
	}

}
