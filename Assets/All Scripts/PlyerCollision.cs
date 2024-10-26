using Unity.VisualScripting;
using UnityEngine;

public class PlyerCollasion : MonoBehaviour {
    
    public PlyerScript plyerScript;
    public Score score;
    public GameController gameController;

    // private void OnCollisionEnter(Collision other) {
    //     // Debug.Log(other.gameObject.name);
    //     if (other.gameObject.tag == "Collectables") {
    //         Destroy(other.gameObject);
    //     }
    // }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Collectables") {
            Destroy(other.gameObject);
            score.AddScore(1);
        }
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Obstracles") {
            plyerScript.enabled = false;
            gameController.GameOver();
        }
    }
}
