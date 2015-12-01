using UnityEngine;
using System.Collections;

public class SplineDecorator : MonoBehaviour {

	public Spline spline;

	public int freq;

	public bool lookForward;

	public Transform[] items;

	private void Awake(){
		if (freq <= 0 || items == null || items.Length == 0) {
			return;
		}

		float stepSize = freq * items.Length;
		if (spline.Loop || stepSize == 1) {
			stepSize = 1f / stepSize;
		} else {
			stepSize = 1f / (stepSize - 1);
		}

//		float stepSize = 1f / (freq * items.Length);
		for (int p = 0, f = 0; f < freq; f++) {
			for (int i = 0; i < items.Length; i++, p++){
				Transform item = Instantiate(items[i]) as Transform;
				Vector3 position = spline.GetPoint(p * stepSize);
				item.transform.localPosition = position;

				if (lookForward) {
					// Bug, only works in 3D
					//	item.transform.LookAt(position + spline.GetDirection(p * stepSize));
				}
		item.transform.parent = transform;
			}
		}
	}
}
