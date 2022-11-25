using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teletransporte : MonoBehaviour
{
    public Collider collider;
    public LayerMask layers;

    public Transform destinationTranform;
    public float delayTime;

    WaitForSeconds delay;
    

    IEnumerator Activate(GameObject teleportee){
        if(destinationTranform){
            yield return delay;
            teleportee.transform.position = destinationTranform.position;
            teleportee.transform.rotation = destinationTranform.rotation;
        }
    }

    void Reset() {
        collider = GetComponent<Collider>();
        collider.isTrigger = true;
        
    }
    
    void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            SceneManager.LoadScene("Nivel2");
            delay = new WaitForSeconds(delayTime);
            
        }
        if (IsTeleportable(other)) StartCoroutine(Activate(other.gameObject));
    }

    bool IsTeleportable(Collider other){
        return 0 != (layers.value & 1 << other.gameObject.layer);
    }
}
