using UnityEngine;
using System.Collections;

public class ScanRelease : MonoBehaviour {
	
	public GameObject 	scanner;
	public GameObject	IRfeed;
	//public Light		IRlight;
	public Camera		myCam;

	void Start () {
	
	}
	
	void Update () {
		
		if(Input.GetKey(KeyCode.F3))
			Release();
		
	}
	
	void Release(){
		
		myCam.GetComponent<Animation>().Play();
		//IRlight.animation.Play();
		scanner.GetComponent<Animation>().Play();
		IRfeed.GetComponent<Animation>().Play();
	}
}
