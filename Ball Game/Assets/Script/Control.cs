using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {
    public float force = 20.0f;
    private Rigidbody rigid;
	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < 0)
        {
            Destroy(gameObject);
            Application.Quit();
        }
	}
    void OnCollisionEnter(Collision collision) {
        rigid.AddForce(new Vector3(Random.Range(-1.5f, 1.5f), 2.0f, 0) * force);
    }
}
