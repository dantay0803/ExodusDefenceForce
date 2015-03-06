using UnityEngine;
using System.Collections;

public class scr_moveProjectile : MonoBehaviour
{

    public float maxSpeed = 10;

    // Update is called once per frame
    void Update(){
        //Check if object goes out of bounds 
        checkPosition();
        //Move object
        moveObject();
    }

    void Start(){
        //Set layer
        gameObject.layer = 10;
        //Get the curret roation value
        Quaternion rot = transform.rotation;
        //imageAngle will be used to set the image angle by flipping the Y rotation
        float imageAngle = rot.eulerAngles.y;
        //Check what grid the object is on
        if (transform.position.x > 14){
            //If the object is on the right grid keep the original image angle
            imageAngle = 0;
        }
        else{
            //If the object is on the left grid flip defualt image angle
            imageAngle = 180;
            //Also set maxSpeed to negative value so projectile moves towards enemy
            maxSpeed = -maxSpeed;
        }
        //Set the rotation value
        rot = Quaternion.Euler(0, imageAngle, 0);
        //Update objects Y rotation value
        transform.rotation = rot;
    }

    //Check if projectile goes off screen
    void checkPosition(){
        //Get position
        Vector3 pos = transform.position;
        //Get object width
        float width = GetComponent<Renderer>().bounds.size.x;
        //Check if object goes out of bounds
        if(pos.x<-2.5 - width || pos.x > 28.5 + width){
            //If true destroy object
            Destroy(gameObject);
        }
    }

    //Move object
    void moveObject(){
        //Get current position
        Vector3 pos = transform.position;
        //Calculate new positon
        pos.x += maxSpeed * Time.deltaTime;
        //Update position
        transform.position = pos;
    }

}