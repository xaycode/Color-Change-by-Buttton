using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script1 : MonoBehaviour {
	public Button Tombol1;
	public Button Tombol2;
	public Toggle myToggle;

	public GameObject Boksnya;
	public float kecepatan = 0f;
	private Renderer rend;

	private bool booltoggle;

	// Use this for initialization
	void Start () {
		booltoggle = true;
		rend = Boksnya.GetComponent<Renderer> ();
	}


	public void baten01 ()
	{	
		rend.material.color = Color.red;
	}
	public void baten02 ()
	{
		rend.material.color = Color.green;
	}
	public void baten03 ()
	{
		rend.material.color = Color.white;
	}

	public void togglenya ()
	{
		if (booltoggle) {
			booltoggle = false;
			rend.material.color = Color.yellow;
		} else if (!booltoggle) {
			booltoggle = true;
			rend.material.color = Color.white;
			
		}

	}

	public void ubahKecepatan(float speed)
	{
		kecepatan = speed;
	}
	// Update is called once per frame
	void Update () {
		Boksnya.transform.Rotate (0f, kecepatan * Time.deltaTime, 0f);
	}
}
