using UnityEngine;
using System.Collections;

public class SplineWalker : MonoBehaviour {

	public Spline spline;
	public Line line;

	public bool lookForward;

	public float duration;
	private float progress;

	public SplineWalkerMode mode;

	private bool goingForward = true;

	// Update is called once per frame
	void Update () {

		if (spline != null) {
			SplineMover ();
		} else if (line != null) {
			LineMover();
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
		
		if (lookForward) {
			// use in 3d
			// transform.LookAt(position + spline.GetDirection(progress));
			print ("Bug: Code to rotate (facing foonly works in 3D");
		}
	}

	private void LineMover () {
		CalculateProgress ();

		this.transform.position = Vector3.Lerp(line.p0, line.p1, progress);

	}

}
