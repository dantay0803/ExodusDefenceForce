using UnityEngine;
using System.Collections;

public class scr_placeDefenceObjects : MonoBehaviour {

    //SetIfTheCameraMoveScriptExists
    public static scr_placeDefenceObjects instance = null;
    //TheAmountOfOil/PointsTheUserHasInOrderToSpawnObjects
    public int oil = 50;
    //SetThePositionToSpawnTheEnemyAt
    float xPos, yPos, zPos = -1;
    //DefineTheCostOfTheDefences
    int drillCost = 50, teslaCost = 50, bobCost  = 100, buzzCost = 125, scatterBoxCost  = 150, aobCost = 150, neonCost = 175;
    int mk48Cost = 200, rayCost = 250, fatManCost = 500, kolokoloCost = 50, mineCost = 75, fireMineCost = 75, bigBoyCost = 200;
    int lnlCost = 100, toastyCost = 150, loadLifterCost = 175;
    //CheckWhatDefenceObjectHasBeenSelected
    bool drillSelected = false;
    bool teslaSelected, bobSelected, buzzSelected, scatterBoxSelected, aobSelected, neonSelected = false;
    bool mk48Selected, raySelected, fatManSelected = false;
    bool kolokoloSelected, mineSelected, fireMineSelected, bigBoySelected = false;
    bool lnlSelected, toastySelected, loadlifterSelected = false;
    //DefineDefenceObjects
    public GameObject drill;
    public GameObject tesla;
    public GameObject bob;
    public GameObject buzz;
    public GameObject scatterBox;
    public GameObject aob;
    public GameObject neon;
    public GameObject mk48;
    public GameObject ray;
    public GameObject fatMan;
    public GameObject kolokolo;
    public GameObject mine;
    public GameObject fireMine;
    public GameObject bigBoy;
    public GameObject lnl;
    public GameObject toasty;
    public GameObject loadLifter;

    // Use this for initialization
    void Awake(){
        //CheckifThereIsNoInstanceOfTheCamera
        if(instance == null){
            instance = this;
        }
        //IfCameraInstanceAlreadyExistsDestroyIt
        else if(instance != null){
            Destroy(gameObject);
        }
        //UpdateTheScoreDisplay
        scr_displayScore.instance.displayOil(oil);
    }

    //CheckWhatSelectionCardWasClickedOn
    public void chooseDefenceObject(string defenceName){
        //ResetWhatObjectHasBeenSelectedIncaseAnotherCardHasBeenSelectedAfterOneWasAlreadySelected
        resetSelectedDefenceObject();
        //SetABooleanToTrueToSpawnInTheObjectThatReleatesToTheSelectionCardClickOn
        //CheckIfTheDrillSelectionCardWasClickedAndTheirIsEnoughOilToBuildItInOrderToAllowTheUserToSpawnIt
        if (defenceName == "obj_drillSelection" && oil >= drillCost){
            drillSelected = true;
        }
        if(defenceName == "obj_teslaSelection(Clone)" && oil >= teslaCost){
            teslaSelected = true;
        }
        if(defenceName == "obj_bobSelection(Clone)" && oil >= bobCost){
            bobSelected = true;
        }
        if(defenceName == "obj_buzzSelection(Clone)" && oil >= buzzCost){
            buzzSelected = true;
        }
        if(defenceName == "obj_scatterBoxSelection(Clone)" && oil >= scatterBoxCost){
            scatterBoxSelected = true;
        }
        if(defenceName == "obj_aobSelection(Clone)" && oil >= aobCost){
            aobSelected = true;
        }
        if(defenceName == "obj_neonSelection(Clone)" && oil >= neonCost){
            neonSelected = true;
        }
        if(defenceName == "obj_mk48Selection(Clone)" && oil >= mk48Cost){
            mk48Selected = true;
        }
        if (defenceName == "obj_raySelection(Clone)" && oil >= rayCost){
            raySelected = true;
        }
        if (defenceName == "obj_fatManSelection(Clone)" && oil >= fatManCost){
            fatManSelected = true;
        }
        if (defenceName == "obj_kolokoloSelection(Clone)" && oil >= kolokoloCost){
            kolokoloSelected = true;
        }
        if (defenceName == "obj_mineSelection(Clone)" && oil >= mineCost){
            mineSelected = true;
        }
        if (defenceName == "obj_fireMineSelection(Clone)" && oil >= fireMineCost){
            fireMineSelected = true;
        }
        if (defenceName == "obj_bigBoySelection(Clone)" && oil >= bigBoyCost){
            bigBoySelected = true;
        }
        if (defenceName == "obj_lnlSelection(Clone)" && oil >= lnlCost){
            lnlSelected = true;
        }
        if (defenceName == "obj_toastySelection(Clone)" && oil >= toastyCost){
            toastySelected = true;
        }
        if (defenceName == "obj_loadLifterSelection(Clone)" && oil >= loadLifterCost){
            loadlifterSelected = true;
        }
    }

    //PlaceTheSelectedObjectOnTheSelectedAreOfTheGrid
    void placeDefenceObjects(){
        //PlaceTheSelectedDefenceObjectInTheLevelAndRemoveTheRequiredAmountOfOil(Points)
        if(drillSelected){
            Instantiate(drill, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= drillCost;
        }
        if(teslaSelected){
            Instantiate(tesla, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= teslaCost;
        }
        if(bobSelected){
            Instantiate(bob, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= bobCost;
        }
        if(buzzSelected){
            Instantiate(buzz, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= buzzCost;
        }
        if(scatterBoxSelected){
            Instantiate(scatterBox, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= scatterBoxCost;
        }
        if(aobSelected){
            Instantiate(aob, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= aobCost;
        }
        if(neonSelected){
            Instantiate(neon, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= neonCost;
        }
        if(mk48Selected){
            Instantiate(mk48, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= mk48Cost;
        }
        if(raySelected){
            Instantiate(ray, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= rayCost;
        }
        if(fatManSelected){
            Instantiate(fatMan, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= fatManCost;
        }
        if(kolokoloSelected){
            Instantiate(kolokolo, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= kolokoloCost;
        }
        if(mineSelected){
            Instantiate(mine, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= mineCost;
        }
        if(fireMineSelected){
            Instantiate(fireMine, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= fireMineCost;
        }
        if(bigBoySelected){
            Instantiate(bigBoy, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= bigBoyCost;
        }
        if(lnlSelected){
            Instantiate(lnl, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= lnlCost;
        }
        if(toastySelected){
            Instantiate(toasty, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= toastyCost;
        }
        if(loadlifterSelected){
            Instantiate(loadLifter, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= loadLifterCost;
        }
        //ResetTheBooleansToCreateTheDefenceObjectsOnceOneHasBeenPlaced
        resetSelectedDefenceObject();
        //UpdateTheScoreDisplay
        scr_displayScore.instance.displayOil(oil);
    }

    //ResetTheDefenceSelectionBooleans
    void resetSelectedDefenceObject(){
        drillSelected = false;
        teslaSelected = false;
        bobSelected = false;
        buzzSelected = false;
        scatterBoxSelected = false;
        aobSelected = false;
        neonSelected = false;
        mk48Selected = false;
        raySelected = false;
        fatManSelected = false;
        kolokoloSelected = false;
        mineSelected = false;
        fireMineSelected = false;
        bigBoySelected = false;
        lnlSelected = false;
        toastySelected = false;
        loadlifterSelected = false;
    }

    //checkForTheUserClicking/TouchingTheGrids
    void OnMouseDown(){
        //CheckIfTheCameraIsShowingTheLeftGridToPlacewTurretsOnThatGrid
        if(Camera.main.transform.position.x == 0){
            //CheckThatTheMouseIsClickedWithinTheBoundsOfTheLeftGrid
            if((Input.mousePosition.x >=65 && Input.mousePosition.x <= 755) && (Input.mousePosition.y >= 0 && Input.mousePosition.y <= 355)){
                //DefineThePositionToCreateTheObjectWhenTheLeftGridIsClicked/Touched
                setObjectSpawnPositionForLeftGrid();
                //DefineTheYPositionToCreateTheObjectWhenTheGridIsClicked/Touched
                setObjectYSpawnPosition();
                //SawnInTheObject
                placeDefenceObjects();
            }
            //ResetObjectSpawnBooleansIsTheUserHasClickedOutSideTheGrid
            else{
                resetSelectedDefenceObject();
            }
        }
        //CheckIfTheCameraIsShowingTheRightGridToPlacewTurretsOnThatGrid
        else if (Camera.main.transform.position.x == 14){
            //CheckThatTheMouseIsClickedWithinTheBoundsOfTheRightGrid
            if((Input.mousePosition.x >= 520 && Input.mousePosition.x <= 1210) && (Input.mousePosition.y >= 0 && Input.mousePosition.y <= 355)){
                //DefineThePositionToCreateTheObjectWhenTheRightGridIsClicked/Touched
                setObjectSpawnPositionForRightGrid();
                //DefineTheYPositionToCreateTheObjectWhenTheGridIsClicked/Touched
                setObjectYSpawnPosition();
                //SawnInTheObject
                placeDefenceObjects();
            }
            //ResetObjectSpawnBooleansIsTheUserHasClickedOutSideTheGrid
            else{
                resetSelectedDefenceObject();
            }
        }
    }

    //DefineXThePositionToCreateTheObjectWhenTheLeftGridIsClicked/Touched
    void setObjectSpawnPositionForLeftGrid(){
        //GetXPosToSpawnInObjects
        if(Input.mousePosition.x >= 65 && Input.mousePosition.x <= 140){
            xPos = -7.5f;
        }
        else if(Input.mousePosition.x >= 145 && Input.mousePosition.x <= 215){
            xPos = -6.4f;
        }
        else if(Input.mousePosition.x >= 220 && Input.mousePosition.x <= 290){
            xPos = -5.3f;
        }
        else if(Input.mousePosition.x >= 300 && Input.mousePosition.x <= 370){
            xPos = -4.25f;
        }
        else if(Input.mousePosition.x >= 375 && Input.mousePosition.x <= 445){
            xPos = -3.2f;
        }
        else if(Input.mousePosition.x >= 450 && Input.mousePosition.x <= 520){
            xPos = -2.1f;
        }
        else if(Input.mousePosition.x >= 530 && Input.mousePosition.x <= 600){
            xPos = -1.05f;
        }
        else if(Input.mousePosition.x >= 605 && Input.mousePosition.x <= 675){
            xPos = 0.03f;
        }
        else if (Input.mousePosition.x >= 685 && Input.mousePosition.x <= 755){
            xPos = 1.1f;
        }
    }

    //DefineTheXPositionToCreateTheObjectWhenTheRightGridIsClicked/Touched
    void setObjectSpawnPositionForRightGrid(){
        //GetXPosToSpawnInObjects
        if(Input.mousePosition.x >= 520 && Input.mousePosition.x <= 590){
            xPos = 12.85f;
        }
        else if(Input.mousePosition.x >= 600 && Input.mousePosition.x <= 670){
            xPos = 13.95f;
        }
        else if(Input.mousePosition.x >= 680 && Input.mousePosition.x <= 750){
            xPos = 15f;
        }
        else if(Input.mousePosition.x >= 755 && Input.mousePosition.x <= 820){
            xPos = 16.1f;
        }
        else if(Input.mousePosition.x >= 830 && Input.mousePosition.x <= 900){
            xPos = 17.15f;
        }
        else if(Input.mousePosition.x >= 910 && Input.mousePosition.x <= 980){
            xPos = 18.23f;
        }
        else if(Input.mousePosition.x >= 990 && Input.mousePosition.x <= 1055){
            xPos = 19.3f;
        }
        else if(Input.mousePosition.x >= 1060 && Input.mousePosition.x <= 1130){
            xPos = 20.36f;
        }
        else if(Input.mousePosition.x >= 1140 && Input.mousePosition.x <= 1210){
            xPos = 21.45f;
        }
    }

    //DefineTheYPositionToCreateTheObjectWhenTheGridIsClicked/Touched
    void setObjectYSpawnPosition(){
        //GetYPosToSpawnInObjects
        if(Input.mousePosition.y >= 290 && Input.mousePosition.y <= 355){
            yPos = -0.5f;
        }
        else if(Input.mousePosition.y >= 220 && Input.mousePosition.y <= 280){
            yPos = -1.5f;
        }
        else if (Input.mousePosition.y >= 145 && Input.mousePosition.y <= 210){
            yPos = -2.5f;
        }
        else if (Input.mousePosition.y >= 75 && Input.mousePosition.y <= 140){
            yPos = -3.5f;
        }
        else if (Input.mousePosition.y >= 0 && Input.mousePosition.y <= 65){
            yPos = -4.5f;
        }
    }
}
