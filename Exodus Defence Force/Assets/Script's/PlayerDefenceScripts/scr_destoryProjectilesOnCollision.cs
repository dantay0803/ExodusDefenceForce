using UnityEngine;
using System.Collections;

public class scr_destoryProjectilesOnCollision : MonoBehaviour {

    //Destroy object when colliding with eneimies
    void OnTriggerEnter2D(Collider2D other)
    {
        switch(other.gameObject.name){
            case "obj_fireSpitter(Clone)":
                Destroy(gameObject);
                break;
            case "obj_gatherer(Clone)":
                Destroy(gameObject);
                break;
            case "obj_hunter(Clone)":
                Destroy(gameObject);
                break;
            case "obj_reinforcedWorker(Clone)":
                Destroy(gameObject);
                break;
            case "obj_rocky(Clone)":
                Destroy(gameObject);
                break;
            case "obj_wheelWorker(Clone)":
                Destroy(gameObject);
                break;
            case "obj_worker(Clone)":
                Destroy(gameObject);
                break;
            case "obj_wreackingBall(Clone)":
                Destroy(gameObject);
                break;
            case "obj_zapper(Clone)":
                Destroy(gameObject);
                break;
            default:
                break;
        }
    }
}
