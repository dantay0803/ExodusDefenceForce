using UnityEngine;
using System.Collections;

public class scr_loadOutSelection : MonoBehaviour {
    public AudioClip snd_buttonClick;
    
    //TrackWhatBaiscTurretThePlayerSelects
    static bool basicTurretSelected = false;
    static bool obj_teslaSelection = false;
    static bool obj_bobSelection = false;
    static bool obj_buzzSelection = false;
    static bool obj_scatterBoxSelection = false;
    static bool obj_aobSelection = false;
    static bool obj_neonSelection = false;
    //TrackWhatHeavyTurretThePlayerSelects
    static bool heavyTurretSelected = false;
    static bool obj_mk48Selection = false;
    static bool obj_raySelection = false;
    static bool obj_fatManSelection = false;
    //TrackWhatMineThePlayerSelects
    static bool mineSelected = false;
    static bool obj_mineSelection = false;
    static bool obj_kolokoloSelection = false;
    static bool obj_fireMineSelection = false;
    static bool obj_bigBoySelection = false;
    //TrackWhatSpecialTurretThePlayerSelects
    static bool specialTurretSelected = false;
    static bool obj_lnlSelection = false;
    static bool obj_toastySelection = false;
    static bool obj_loadLifterSelection = false;
    //DefineSelectionCardObjects
    public GameObject obj_teslaSelectionCard;
    public GameObject obj_bobSelectionCard;
    public GameObject obj_buzzSelectionCard;
    public GameObject obj_scatterBoxSelectionCard;
    public GameObject obj_aobSelectionCard;
    public GameObject obj_neonSelectionCard;
    public GameObject obj_mk48SelectionCard;
    public GameObject obj_raySelectionCard;
    public GameObject obj_fatManSelectionCard;
    public GameObject obj_mineSelectionCard;
    public GameObject obj_kolokoloSelectionCard;
    public GameObject obj_fireMineSelectionCard;
    public GameObject obj_bigBoySelectionCard;
    public GameObject obj_lnlSelectionCard;
    public GameObject obj_toastySelectionCard;
    public GameObject obj_loadLifterSelectionCard;

    void Start()
    {
        spawnInCards();
    }

    //LaunchTheLevelOnceThePlayerIsHappyWithTheirLoadout
    public void startGame(){
        Debug.Log(basicTurretSelected.ToString() + heavyTurretSelected.ToString() + mineSelected.ToString() + specialTurretSelected.ToString());
        if (basicTurretSelected && heavyTurretSelected && mineSelected && specialTurretSelected){
            Debug.Log("if statement ran");
            //CheckTheSceneNameThatWasSavedToRepresentTheLastLevel
            switch (PlayerPrefs.GetString("lastLevel")){
                case "scene_levelOne":
                    Application.LoadLevel("scene_levelOne");
                    break;
                case "scene_levelTwo":
                    Application.LoadLevel("scene_levelTwo");
                    break;
                case "scene_levelThree":
                    Application.LoadLevel("scene_levelThree");
                    break;
                case "scene_levelFour":
                    Application.LoadLevel("scene_levelFour");
                    break;
                case "scene_levelFive":
                    Application.LoadLevel("scene_levelFive");
                    break;
                case "scene_levelSix":
                    Application.LoadLevel("scene_levelSix");
                    break;
                default:
                    Application.LoadLevel("scene_levelOne");
                    break;
            }
            //Play the button click clip using the sound manager object
            scr_soundManager.instance.playSingle(snd_buttonClick);
        }
    }

    //CheckForplayerClick/PressOnObjectToSelectPlayerLoadout
    void OnMouseDown(){
        //CheckForClick/PressOnObject
        if(Input.GetMouseButtonDown(0) && Application.loadedLevelName == "scene_defenceSelection"){
            //CheckTheNameOfTheSelectionCardClickedOnToChooseWhatObjectIsSelected
            switch (this.gameObject.name){
                //BaiscTurretSelection
                case "obj_teslaSelection":
                    obj_teslaSelection = true;
                    obj_bobSelection = false;
                    obj_buzzSelection = false;
                    obj_scatterBoxSelection = false;
                    obj_aobSelection = false;
                    obj_neonSelection = false;
                    basicTurretSelected = true;
                    break;
                case "obj_bobSelection":
                    obj_teslaSelection = false;
                    obj_bobSelection = true;
                    obj_buzzSelection = false;
                    obj_scatterBoxSelection = false;
                    obj_aobSelection = false;
                    obj_neonSelection = false;
                    basicTurretSelected = true;
                    break;
                case "obj_buzzSelection":
                    obj_teslaSelection = false;
                    obj_bobSelection = false;
                    obj_buzzSelection = true;
                    obj_scatterBoxSelection = false;
                    obj_aobSelection = false;
                    obj_neonSelection = false;
                    basicTurretSelected = true;
                    break;
                case "obj_scatterBoxSelection":
                    obj_teslaSelection = false;
                    obj_bobSelection = false;
                    obj_buzzSelection = false;
                    obj_scatterBoxSelection = true;
                    obj_aobSelection = false;
                    obj_neonSelection = false;
                    basicTurretSelected = true;
                    break;
                case "obj_aobSelection":
                    obj_teslaSelection = false;
                    obj_bobSelection = false;
                    obj_buzzSelection = false;
                    obj_scatterBoxSelection = false;
                    obj_aobSelection = true;
                    obj_neonSelection = false;
                    basicTurretSelected = true;
                    break;
                case "obj_neonSelection":
                    obj_teslaSelection = false;
                    obj_bobSelection = false;
                    obj_buzzSelection = false;
                    obj_scatterBoxSelection = false;
                    obj_aobSelection = false;
                    obj_neonSelection = true;
                    basicTurretSelected = true;
                    break;
                //HeavyTurretSelection
                case "obj_mk48Selection":
                    obj_mk48Selection = true;
                    obj_raySelection = false;
                    obj_fatManSelection = false;
                    heavyTurretSelected = true;
                    break;
                case "obj_raySelection":
                    obj_mk48Selection = false;
                    obj_raySelection = true;
                    obj_fatManSelection = false;
                    heavyTurretSelected = true;
                    break;
                case "obj_fatManSelection":
                    obj_mk48Selection = false;
                    obj_raySelection = false;
                    obj_fatManSelection = true;
                    heavyTurretSelected = true;
                    break;
                //MineSelection
                case "obj_mineSelection":
                    obj_mineSelection = true;
                    obj_kolokoloSelection = false;
                    obj_fireMineSelection = false;
                    obj_bigBoySelection = false;
                    mineSelected = true;
                    break;
                case "obj_kolokoloSelection":
                    obj_mineSelection = false;
                    obj_kolokoloSelection = true;
                    obj_fireMineSelection = false;
                    obj_bigBoySelection = false;
                    mineSelected = true;
                    break;
                case "obj_fireMineSelection":
                    obj_mineSelection = false;
                    obj_kolokoloSelection = false;
                    obj_fireMineSelection = true;
                    obj_bigBoySelection = false;
                    mineSelected = true;
                    break;
                case "obj_bigBoySelection":
                    obj_mineSelection = false;
                    obj_kolokoloSelection = false;
                    obj_fireMineSelection = false;
                    obj_bigBoySelection = true;
                    mineSelected = true;
                    break;
                //SpecialTurretSelection
                case "obj_lnlSelection":
                    obj_lnlSelection = true;
                    obj_toastySelection = false;
                    obj_loadLifterSelection = false;
                    specialTurretSelected = true;
                    break;
                case "obj_toastySelection":
                    obj_lnlSelection = false;
                    obj_toastySelection = true;
                    obj_loadLifterSelection = false;
                    specialTurretSelected = true;
                    break;
                case "obj_loadLifterSelection":
                    obj_lnlSelection = false;
                    obj_toastySelection = false;
                    obj_loadLifterSelection = true;
                    specialTurretSelected = true;
                    break;
            }
            //Play the button click clip using the sound manager object
            scr_soundManager.instance.playSingle(snd_buttonClick);
        }
    }    

    void spawnInCards(){
        //SetTheSpawnPositionsOfTheCards
        float basicTurretCardXPos = -4.5f;
        float heavyTurretCardXPos = -3;
        float mineCardXPos = -1.5f;
        float SpecialTurretCardXPos = 0;
        float cardYPos = 1.45f;
        if(Application.loadedLevelName == "scene_levelOne"){
            //PlaceSelectedBaiscTurretInTheLevel
            if(obj_teslaSelection){
                Instantiate(obj_teslaSelectionCard, new Vector3(basicTurretCardXPos, cardYPos, -1), Quaternion.identity);
            }
            else if(obj_bobSelection){
                Instantiate(obj_bobSelectionCard, new Vector3(basicTurretCardXPos, cardYPos, -1), Quaternion.identity);
            }
            else if(obj_buzzSelection){
                Instantiate(obj_buzzSelectionCard, new Vector3(basicTurretCardXPos, cardYPos, -1), Quaternion.identity);
            }
            else if(obj_scatterBoxSelection){
                Instantiate(obj_scatterBoxSelectionCard, new Vector3(basicTurretCardXPos, cardYPos, -1), Quaternion.identity);
            }
            else if(obj_aobSelection){
                Instantiate(obj_aobSelectionCard, new Vector3(basicTurretCardXPos, cardYPos, -1), Quaternion.identity);
            }
            else if(obj_neonSelection){
                Instantiate(obj_neonSelectionCard, new Vector3(basicTurretCardXPos, cardYPos, -1), Quaternion.identity);
            }
            //PlaceSelectedHeavyTurretInTheLevel
            if(obj_mk48Selection){
                Instantiate(obj_mk48SelectionCard, new Vector3(heavyTurretCardXPos, cardYPos, -1), Quaternion.identity);
            }
            else if(obj_raySelection){
                Instantiate(obj_raySelectionCard, new Vector3(heavyTurretCardXPos, cardYPos, -1), Quaternion.identity);
            }
            else if(obj_fatManSelection){
                Instantiate(obj_fatManSelectionCard, new Vector3(heavyTurretCardXPos, cardYPos, -1), Quaternion.identity);
            }
            //PlaceSelectedMineInTheLevel
            if (obj_mineSelection) {
                Instantiate(obj_mineSelectionCard, new Vector3(mineCardXPos, cardYPos, -1), Quaternion.identity);
            }
            else if (obj_kolokoloSelection){
                Instantiate(obj_kolokoloSelectionCard, new Vector3(mineCardXPos, cardYPos, -1), Quaternion.identity);
            }
            else if (obj_fireMineSelection){
                Instantiate(obj_fireMineSelectionCard, new Vector3(mineCardXPos, cardYPos, -1), Quaternion.identity);
            }
            else if (obj_bigBoySelection){
                Instantiate(obj_bigBoySelectionCard, new Vector3(mineCardXPos, cardYPos, -1), Quaternion.identity);
            }
            //PlaceSelectedSpecialTurretInTheLevel
            if(obj_lnlSelection){
                Instantiate(obj_lnlSelectionCard, new Vector3(SpecialTurretCardXPos, cardYPos, -1), Quaternion.identity);
            }
            else if(obj_toastySelection){
                Instantiate(obj_toastySelectionCard, new Vector3(SpecialTurretCardXPos, cardYPos, -1), Quaternion.identity);
            }
            else if(obj_loadLifterSelection){
                Instantiate(obj_loadLifterSelectionCard, new Vector3(SpecialTurretCardXPos, cardYPos, -1), Quaternion.identity);
            }
        }
    }
}
