using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class scorem : MonoBehaviour {
    Text scorelabel;
    public static int score;
	// Use this for initialization
	void Start () {
        scorelabel = GetComponent<Text>();
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        scorelabel.text = scorem.score.ToString();
        scoree.score2 = score;
	}
}
