using UnityEngine;
using System.Collections;

public class scr_chooseRandomPosition : MonoBehaviour {

	//CallAwakeFunctionInsteadOfStartToEnsureTheEnemyPositionIsSelectedBeforeAnyOtherEvents
	void Awake () {
        //HoldTherandomlyGeneratedPosition
        float randomYPos = 0, randomXPos = 0;
        //RandomlyGenerateAYPosition
        switch(Random.Range(0, 5)){
            case 0:
                randomYPos = -0.5f;
                break;
            case 1:
                randomYPos = -1.5f;
                break;
            case 2:
                randomYPos = -2.5f;
                break;
            case 3:
                randomYPos = -3.5f;
                break;
            case 4:
                randomYPos = -4.5f;
                break;
            default:
                randomYPos = -2.5f;
                break;
        }
        //RandomlyGenerateAnXPosition
        switch (Random.Range(0, 2)){
            case 0:
                randomXPos = -8.5f;
                flipImage();
                break;
            case 1:
                randomXPos = 22.5f;
                break;
            default:
                randomXPos = 22.5f;
                break;
        }
        //UpdateTheEnemyObjectsPosition
        this.transform.position = new Vector3(randomXPos, randomYPos, this.transform.position.z);
	}

    //FlipTheImageIfItSpawnsOnTheLeftGrid
    void flipImage()
    {
        //GetTheCurretRotationvaluesOfTheObject
        Vector3 imageScale = transform.localScale;
        //FlipTheImageOnItsYAxis
        imageScale.x *= -1;
        //UpdateImageRotation
        transform.localScale = imageScale;
    }
}
