using UnityEngine;

public class FllowPlayer : MonoBehaviour {
    public Transform plyerTransform;
    public float offSet = 8.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        Vector3 cameraPos = transform.position;
        cameraPos.z = plyerTransform.position.z + offSet;
        transform.position = cameraPos;
    }
}
