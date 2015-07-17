using UnityEngine;
using System.Collections;

public class scr_moveCamera : MonoBehaviour {
    //SetIfTheCameraMoveScriptExists
    public static scr_moveCamera instance = null;

    // Use this for initialization
    void Awake(){
        //CheckifThereIsNoInstanceOfTheCamera
        if (instance == null){
            instance = this;
        }
        //IfCameraInstanceAlreadyExistsDestroyIt
        else if (instance != null){
            Destroy(gameObject);
        }
        //StopTheCameraBeingDestroyedOnLoadBetweenScenes
        DontDestroyOnLoad(gameObject);
    }

    //MoveTheCameraToShowTheleftGrid
    public void showLeftGrid(){
        //UpdateCameraPos
        this.transform.position = new Vector3(0, 0, -10);
        //UpdateCardBackingPos       
        GameObject obj_cardBacking = GameObject.Find("obj_cardBacking");
        obj_cardBacking.transform.position = new Vector3((obj_cardBacking.transform.position.x - 21), obj_cardBacking.transform.position.y, obj_cardBacking.transform.position.z);
        //UpdateThePositionOfTheSelectionCards
        updateCardPosition();
    }

    //MoveTheCameraToShowTheleftGrid
    public void showRightGrid(){
        //UpdateCameraPos
        this.transform.position = new Vector3(14, 0, -10);
        //UpdateCardBackingPos       
        GameObject obj_cardBacking = GameObject.Find("obj_cardBacking");
        obj_cardBacking.transform.position = new Vector3((obj_cardBacking.transform.position.x + 21), obj_cardBacking.transform.position.y, obj_cardBacking.transform.position.z);
        //UpdateThePositionOfTheSelectionCards
        updateCardPosition();
    }

    //MoveTheCardsWhenTheCameraMoves
    void updateCardPosition(){
        //SetTheValueToAltarTheCardsPositionBy
        float posXValue = 0;
        if(this.transform.position.x == 0){
            posXValue = -21f;
        }
        else if(this.transform.position.x == 14){
            posXValue = 21f;
        }
        //MoveDrillCard
        GameObject.Find("obj_drillSelection").transform.position = new Vector3((GameObject.Find("obj_drillSelection").transform.position.x + posXValue), GameObject.Find("obj_drillSelection").transform.position.y, GameObject.Find("obj_drillSelection").transform.position.z);
        //CheckWhatOtherCardsExistAndMoveThem
        if(GameObject.Find("obj_aobSelection(Clone)") != null){
            GameObject.Find("obj_aobSelection(Clone)").transform.position = new Vector3((GameObject.Find("obj_aobSelection(Clone)").transform.position.x + posXValue), GameObject.Find("obj_aobSelection(Clone)").transform.position.y, GameObject.Find("obj_aobSelection(Clone)").transform.position.z);
        }
        if(GameObject.Find("obj_bigBoySelection(Clone)") != null){
            GameObject.Find("obj_bigBoySelection(Clone)").transform.position = new Vector3((GameObject.Find("obj_bigBoySelection(Clone)").transform.position.x + posXValue), GameObject.Find("obj_bigBoySelection(Clone)").transform.position.y, GameObject.Find("obj_bigBoySelection(Clone)").transform.position.z);
        }
        if(GameObject.Find("obj_bobSelection(Clone)") != null){
            GameObject.Find("obj_bobSelection(Clone)").transform.position = new Vector3((GameObject.Find("obj_bobSelection(Clone)").transform.position.x + posXValue), GameObject.Find("obj_bobSelection(Clone)").transform.position.y, GameObject.Find("obj_bobSelection(Clone)").transform.position.z);
        }
        if(GameObject.Find("obj_buzzSelection(Clone)") != null){
            GameObject.Find("obj_buzzSelection(Clone)").transform.position = new Vector3((GameObject.Find("obj_buzzSelection(Clone)").transform.position.x + posXValue), GameObject.Find("obj_buzzSelection(Clone)").transform.position.y, GameObject.Find("obj_buzzSelection(Clone)").transform.position.z);
        }
        if(GameObject.Find("obj_fatManSelection(Clone)") != null){
            GameObject.Find("obj_fatManSelection(Clone)").transform.position = new Vector3((GameObject.Find("obj_fatManSelection(Clone)").transform.position.x + posXValue), GameObject.Find("obj_fatManSelection(Clone)").transform.position.y, GameObject.Find("obj_fatManSelection(Clone)").transform.position.z);
        }
        if(GameObject.Find("obj_fireMineSelection(Clone)") != null){
            GameObject.Find("obj_fireMineSelection(Clone)").transform.position = new Vector3((GameObject.Find("obj_fireMineSelection(Clone)").transform.position.x + posXValue), GameObject.Find("obj_fireMineSelection(Clone)").transform.position.y, GameObject.Find("obj_fireMineSelection(Clone)").transform.position.z);
        }
        if(GameObject.Find("obj_kolokoloSelection(Clone)") != null){
            GameObject.Find("obj_kolokoloSelection(Clone)").transform.position = new Vector3((GameObject.Find("obj_kolokoloSelection(Clone)").transform.position.x + posXValue), GameObject.Find("obj_kolokoloSelection(Clone)").transform.position.y, GameObject.Find("obj_kolokoloSelection(Clone)").transform.position.z);
        }
        if(GameObject.Find("obj_lnlSelection(Clone)") != null){
            GameObject.Find("obj_lnlSelection(Clone)").transform.position = new Vector3((GameObject.Find("obj_lnlSelection(Clone)").transform.position.x + posXValue), GameObject.Find("obj_lnlSelection(Clone)").transform.position.y, GameObject.Find("obj_lnlSelection(Clone)").transform.position.z);
        }
        if(GameObject.Find("obj_loadLifterSelection(Clone)") != null){
            GameObject.Find("obj_loadLifterSelection(Clone)").transform.position = new Vector3((GameObject.Find("obj_loadLifterSelection(Clone)").transform.position.x + posXValue), GameObject.Find("obj_loadLifterSelection(Clone)").transform.position.y, GameObject.Find("obj_loadLifterSelection(Clone)").transform.position.z);
        }
        if(GameObject.Find("obj_mineSelection(Clone)") != null){
            GameObject.Find("obj_mineSelection(Clone)").transform.position = new Vector3((GameObject.Find("obj_mineSelection(Clone)").transform.position.x + posXValue), GameObject.Find("obj_mineSelection(Clone)").transform.position.y, GameObject.Find("obj_mineSelection(Clone)").transform.position.z);
        }
        if(GameObject.Find("obj_mk48Selection(Clone)") != null){
            GameObject.Find("obj_mk48Selection(Clone)").transform.position = new Vector3((GameObject.Find("obj_mk48Selection(Clone)").transform.position.x + posXValue), GameObject.Find("obj_mk48Selection(Clone)").transform.position.y, GameObject.Find("obj_mk48Selection(Clone)").transform.position.z);
        }
        if(GameObject.Find("obj_neonSelection(Clone)") != null){
            GameObject.Find("obj_neonSelection(Clone)").transform.position = new Vector3((GameObject.Find("obj_neonSelection(Clone)").transform.position.x + posXValue), GameObject.Find("obj_neonSelection(Clone)").transform.position.y, GameObject.Find("obj_neonSelection(Clone)").transform.position.z);
        }
        if(GameObject.Find("obj_raySelection(Clone)") != null){
            GameObject.Find("obj_raySelection(Clone)").transform.position = new Vector3((GameObject.Find("obj_raySelection(Clone)").transform.position.x + posXValue), GameObject.Find("obj_raySelection(Clone)").transform.position.y, GameObject.Find("obj_raySelection(Clone)").transform.position.z);
        }
        if(GameObject.Find("obj_scatterBoxSelection(Clone)") != null){
            GameObject.Find("obj_scatterBoxSelection(Clone)").transform.position = new Vector3((GameObject.Find("obj_scatterBoxSelection(Clone)").transform.position.x + posXValue), GameObject.Find("obj_scatterBoxSelection(Clone)").transform.position.y, GameObject.Find("obj_scatterBoxSelection(Clone)").transform.position.z);
        }
        if(GameObject.Find("obj_teslaSelection(Clone)") != null){
            GameObject.Find("obj_teslaSelection(Clone)").transform.position = new Vector3((GameObject.Find("obj_teslaSelection(Clone)").transform.position.x + posXValue), GameObject.Find("obj_teslaSelection(Clone)").transform.position.y, GameObject.Find("obj_teslaSelection(Clone)").transform.position.z);
        }
        if (GameObject.Find("obj_toastySelection(Clone)") != null){
            GameObject.Find("obj_toastySelection(Clone)").transform.position = new Vector3((GameObject.Find("obj_toastySelection(Clone)").transform.position.x + posXValue), GameObject.Find("obj_toastySelection(Clone)").transform.position.y, GameObject.Find("obj_toastySelection(Clone)").transform.position.z);
        }
    }
}
