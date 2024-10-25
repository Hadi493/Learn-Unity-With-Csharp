using UnityEngine;

public class PlyerScript : MonoBehaviour {

    // all variables
    public float force = 100f;
    public float speed = 10f;
    public float max_x = 12.19f;
    public float min_x = -1.29f;

    public new Rigidbody rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        Vector3 plyerPos = transform.position;
        if (plyerPos.x < min_x) {
            plyerPos.x = min_x;
        }
        // transform.position = plyerPos;
        if (plyerPos.x > max_x) {
            plyerPos.x = max_x;
        }
        // plyerPos.x = Mathf.Clamp(plyerPos.x, max_x, min_x);
        transform.position = plyerPos;
        
        // right forword 
        if (Input.GetKey(KeyCode.RightArrow)) {
            // Debug.Log("Clicked right!");
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
        }
        // left forword
        if (Input.GetKey(KeyCode.LeftArrow)) {
            // Debug.Log("Clicked left!");
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }

    private void FixedUpdate() {
        transform.position = transform.position - new Vector3(0, 0, force * Time.deltaTime);
        // rigidbody.AddForce(0, 0, 1f * Time.deltaTime);
    }
}
