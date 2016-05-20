using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    public float speed = 5.0f;
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*horizontal*speed*Time.deltaTime);
	}
}
