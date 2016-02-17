using UnityEngine;
using System.Collections;

public class SplineWalker : MonoBehaviour {

	public Spline spline;
	public Line[] lineArray;

	public bool lookForward;

	public float duration;
	private float progress;

	//DIRTY CODE
	private float progress2;
	private float progress3;
	private float progress4;
	private float progress5;
	private float progress6;
	private float progress7;
	private float progress8;
	private float progress9;
	//

	public SplineWalkerMode mode;

	private bool goingForward;

	// DIRTY CODE
	private bool goingForward2;
	private bool goingForward3;
	private bool goingForward4;
	private bool goingForward5;
	private bool goingForward6;
	private bool goingForward7;
	private bool goingForward8;
	private bool goingForward9;
	//


	// Update is called once per frame
	void Update () {

		if (spline != null) {
			SplineMover ();
		} else if (lineArray != null) {
			LineMover ();
		} 
	}

	private void CalculateProgress () {

		if (goingForward) {
			progress += Time.deltaTime / duration;
			if (progress > 1f) {
				if (mode == SplineWalkerMode.Once) {
					progress = 1f;
				} else if (mode == SplineWalkerMode.Loop) {
					progress -= 1f;
				} else { 
					progress = 2f - progress;
					goingForward = false;

				}
			}
		}
		else {
			progress -= Time.deltaTime / duration;
			if (progress < 0f) {
				progress = -progress;
				goingForward = true;
			}
		}

	}

	private void SplineMover () {
		CalculateProgress ();
		
		Vector3 position = spline.GetPoint (progress);
		transform.localPosition = position;

		Debug.Log (goingForward);

		if (lookForward) {
			// use in 3d
			// transform.LookAt(position + spline.GetDirection(progress));
			print ("Bug: Code to rotate (facing foonly works in 3D");
		}
	}

	private void LineMover () {

	for(int i = 0; i < lineArray.Length; i++){

			if(lineArray[0] != null){
			

			//Debug.Log(lineArray[i]);
			//Debug.Log(lineArray[i].p0);
			//Debug.Log(lineArray[i].p1);

			CalculateProgress();

			this.transform.position = Vector3.Lerp(lineArray[0].p0, lineArray[0].p1, progress);

			// DIRTY CODE BELOW
				// REALLY DIRTY CODE ;A;

			if (this.transform.position == lineArray[0].p1 && lineArray[1] != null) {
				Debug.Log ("done, now trying next line motion");

				goingForward2 = true;

				CalculateProgress2();

				this.transform.position = Vector3.Lerp(lineArray[1].p0, lineArray[1].p1, progress2);

				if (this.transform.position == lineArray[1].p1) {
					Debug.Log ("done, now trying next line motion");
					
					goingForward3 = true;
					
					CalculateProgress3();
					
					this.transform.position = Vector3.Lerp(lineArray[2].p0, lineArray[2].p1, progress3);

					if (this.transform.position == lineArray[2].p1) {
						Debug.Log ("done, now trying next line motion");
						
						goingForward4 = true;
						
						CalculateProgress4();
						
						this.transform.position = Vector3.Lerp(lineArray[3].p0, lineArray[3].p1, progress4);

						if (this.transform.position == lineArray[3].p1) {
							Debug.Log ("done, now trying next line motion");
							
							goingForward5 = true;
							
							CalculateProgress5();
							
							this.transform.position = Vector3.Lerp(lineArray[4].p0, lineArray[4].p1, progress5);
						}
					}
				}
			}
			}






		}

	}


	// DIRTY CODE

	private void CalculateProgress2 () {
		if (goingForward2) {
			progress2 += Time.deltaTime / duration;
			if (progress2 > 1f) {
				if (mode == SplineWalkerMode.Once) {
					progress2 = 1f;
				} else if (mode == SplineWalkerMode.Loop) {
					progress2 -= 1f;
				} else { 
					progress2 = 2f - progress2;
					goingForward2 = false;
				}
			}
		}
		else {
			progress2 -= Time.deltaTime / duration;
			if (progress2 < 0f) {
				progress2 = -progress2;
				goingForward2 = true;
			}
		}
	}
	private void CalculateProgress3 () {
		if (goingForward3) {
			progress3 += Time.deltaTime / duration;
			if (progress3 > 1f) {
				if (mode == SplineWalkerMode.Once) {
					progress3 = 1f;
				} else if (mode == SplineWalkerMode.Loop) {
					progress3 -= 1f;
				} else { 
					progress3 = 2f - progress3;
					goingForward3 = false;
				}
			}
		}
		else {
			progress3 -= Time.deltaTime / duration;
			if (progress3 < 0f) {
				progress3 = -progress3;
				goingForward3 = true;
			}
		}
	}
	private void CalculateProgress4 () {
		if (goingForward4) {
			progress4 += Time.deltaTime / duration;
			if (progress4 > 1f) {
				if (mode == SplineWalkerMode.Once) {
					progress4 = 1f;
				} else if (mode == SplineWalkerMode.Loop) {
					progress4 -= 1f;
				} else { 
					progress4 = 2f - progress4;
					goingForward4 = false;
				}
			}
		}
		else {
			progress4 -= Time.deltaTime / duration;
			if (progress4 < 0f) {
				progress4 = -progress4;
				goingForward4 = true;
			}
		}
	}
	private void CalculateProgress5 () {
		if (goingForward5) {
			progress5 += Time.deltaTime / duration;
			if (progress5 > 1f) {
				if (mode == SplineWalkerMode.Once) {
					progress5 = 1f;
				} else if (mode == SplineWalkerMode.Loop) {
					progress5 -= 1f;
				} else { 
					progress5 = 2f - progress5;
					goingForward5 = false;
				}
			}
		}
		else {
			progress5 -= Time.deltaTime / duration;
			if (progress5 < 0f) {
				progress5 = -progress5;
				goingForward5 = true;
			}
		}
	}



}
