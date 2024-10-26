using Unity.VisualScripting;
using UnityEngine;

public class PlyerCollasion : MonoBehaviour {
    
    public PlyerScript plyerScript;

    // private void OnCollisionEnter(Collision other) {
    //     // Debug.Log(other.gameObject.name);
    //     if (other.gameObject.tag == "Collectables") {
    //         Destroy(other.gameObject);
    //     }
    // }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Collectables") {
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Obstracles") {
            plyerScript.enabled = false;
        }
    }
}
