using UnityEngine;
using System.Collections;

public class Camlerp : MonoBehaviour {


    public Transform posicioninicial;
    public Transform posicionfinal;
    float lerpspeed = .003f;
    //float starttime;
    //float distanciatotal;
	// Use this for initialization
	void Start () {
        //starttime = Time.time + 2f;
       // distanciatotal = Vector3.Distance(posicioninicial.position, posicionfinal.position);
      
	
	}
	
	// Update is called once per frame
	void Update () {

       // float currentDuration = Time.time - starttime;
      //  float journeyfraction = currentDuration / distanciatotal;
        transform.position = Vector3.Lerp(posicioninicial.position, posicionfinal.position, lerpspeed);
            Time.timeScale = .3f;

    }
}
