using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoree : MonoBehaviour {
    Text score;
    public static int score2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        score.text ="SCORE : "+ score2.ToString();
	}
}
