using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {
    public GameObject coin;
    public GameObject explosion;
    public bool isSpawn = false;

    public static manager instance = null;

    void Awake()
    {
        instance = this;
    }

	// Update is called once per frame
	void Update () {



        if (isSpawn)
        {
            isSpawn = false;
            StartCoroutine(MakeCoin());
        }

        if (scorem.score >= 100)
            Instantiate(explosion, transform.position, transform.rotation);
		
	}
    IEnumerator MakeCoin()
    {
        isSpawn = false;
        yield return new WaitForSeconds(0.2f);
        Instantiate(coin, transform.position, Quaternion.identity);
        transform.Translate(new Vector3(0f, 0.015f, 0.0f));
        
    }
}
