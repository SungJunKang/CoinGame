using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class coin : MonoBehaviour {
    private Rigidbody rb;
    private Collider cd;

    int a=1;
    float speed;
	// Use this for initialization
	void Start () {
         rb = GetComponent<Rigidbody>();
         speed = 0.005f;
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < -0.15)
            a *= -1;
        else if (transform.position.x > 0.14)
            a *= -1;
        if (!rb.useGravity)
        {
            transform.Translate(new Vector3(speed * a, 0.0f, 0.0f));
        }
        if (Input.GetMouseButtonDown(0))
        {
            rb.useGravity = true;
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
            manager.instance.isSpawn = true;
            scorem.score++;
            cameram.isMove = true;
            speed += 0.003f;
       


            
        }
        if (transform.position.y < -0.25)
            SceneManager.LoadScene("end");

	}

}

