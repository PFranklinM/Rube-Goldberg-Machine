using UnityEngine;
using System.Collections;

public class cameraMove : MonoBehaviour {

	public GameObject checkpoint1;
	public GameObject checkpoint2;
	public GameObject checkpoint3;
	public GameObject checkpoint4;
	public GameObject checkpoint5;
	public GameObject checkpoint6;
	public GameObject checkpoint7;
	public GameObject checkpoint8;

	bool leg1 = true;
	bool leg2 = false;
	bool leg3 = false;
	bool leg4 = false;
	bool leg5 = false;
	bool leg6 = false;
	bool leg7 = false;
	bool leg8 = false;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if (leg1 == true) {
			transform.position = Vector3.MoveTowards (transform.position,
				checkpoint1.transform.position,
				Time.deltaTime * 10f);
		}

		if (Vector3.Distance (transform.position, checkpoint1.transform.position) <= 10) {
			leg1 = false;
			leg2 = true;
		}

		if (leg2 == true) {
			transform.position = Vector3.MoveTowards (transform.position,
				checkpoint2.transform.position,
				Time.deltaTime * 15f);
		}

		if (Vector3.Distance (transform.position, checkpoint2.transform.position) <= 10) {
			leg2 = false;
			leg3 = true;
		}

		if (leg3 == true) {
			transform.position = Vector3.MoveTowards (transform.position,
				checkpoint3.transform.position,
				Time.deltaTime * 8.5f);
		}

		if (Vector3.Distance (transform.position, checkpoint3.transform.position) <= 10) {
			leg3 = false;
			leg4 = true;
		}

		if (leg4 == true) {
			transform.position = Vector3.MoveTowards (transform.position,
				checkpoint4.transform.position,
				Time.deltaTime * 15f);

			transform.Rotate (Time.deltaTime * -0.9f, 0, 0);
		}

		if (Vector3.Distance (transform.position, checkpoint4.transform.position) <= 10) {
			leg4 = false;
			leg5 = true;
		}

		if (leg5 == true) {
			transform.position = Vector3.MoveTowards (transform.position,
				checkpoint5.transform.position,
				Time.deltaTime * 30f);
		}

		if (Vector3.Distance (transform.position, checkpoint5.transform.position) <= 10) {
			leg5 = false;
			leg6 = true;
		}

		if (leg6 == true) {
			transform.position = Vector3.MoveTowards (transform.position,
				checkpoint6.transform.position,
				Time.deltaTime * 10f);
		}

		if (Vector3.Distance (transform.position, checkpoint6.transform.position) <= 10) {
			leg6 = false;
			leg7 = true;
		}

		if (leg7 == true) {
			transform.position = Vector3.MoveTowards (transform.position,
				checkpoint7.transform.position,
				Time.deltaTime * 5f);
		}

		if (Vector3.Distance (transform.position, checkpoint7.transform.position) <= 10) {
			leg7 = false;
			leg8 = true;
		}

		if (leg8 == true) {
			transform.position = Vector3.MoveTowards (transform.position,
				checkpoint8.transform.position,
				Time.deltaTime * 25f);

			transform.Rotate (Time.deltaTime * 0.9f, 0, 0);
		}

		if (Vector3.Distance (transform.position, checkpoint8.transform.position) <= 10) {
			leg8 = false;
		}
	
	}
}
