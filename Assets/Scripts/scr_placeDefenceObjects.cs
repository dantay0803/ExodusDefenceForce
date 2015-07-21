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
    //SetTheCoolDownDelayValuesForPlacingDefences
    float aobCoolDownTimer, bigBoyCoolDownTimer, bobCoolDownTimer, buzzCoolDownTimer, drillCoolDownTimer, fatManCoolDownTimer;
    float kolokoloCoolDownTimer, lnlCoolDownTimer, loadLifterCoolDownTimer, mineCoolDownTimer, mk48CoolDownTimer, neonCoolDownTimer;
    float rayCoolDownTimer, scatterBoxCoolDownTimer, teslaCoilCoolDownTimer, toastyCoolDownTimer, fireMineCoolDownTimer;
    //CheckWhatDefenceObjectHasBeenSelected
    bool drillSelected = false;
    bool teslaSelected, bobSelected, buzzSelected, scatterBoxSelected, aobSelected, neonSelected = false;
    bool mk48Selected, raySelected, fatManSelected = false;
    bool kolokoloSelected, mineSelected, fireMineSelected, bigBoySelected = false;
    bool lnlSelected, toastySelected, loadlifterSelected = false;
    //DefineDefenceObjects
    public GameObject drill, tesla, bob, buzz, scatterBox, aob, neon, mk48, ray, fatMan, kolokolo, mine, fireMine, bigBoy, lnl, toasty, loadLifter;

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
    }

    // Update is called once per frame
    void Update(){
        //ReduceDefenceCoolDOwnTimersIfAnyAreOver0
        countDownCoolDownTimers();
    }

    //ReduceDefenceCoolDOwnTimersIfAnyAreOver0
    void countDownCoolDownTimers(){
        if (aobCoolDownTimer > 0){
            aobCoolDownTimer -= Time.deltaTime;
        }
        if (bigBoyCoolDownTimer > 0){
            bigBoyCoolDownTimer -= Time.deltaTime;
        }
        if (bobCoolDownTimer > 0){
            bobCoolDownTimer -= Time.deltaTime;
        }
        if (buzzCoolDownTimer > 0){
            buzzCoolDownTimer -= Time.deltaTime;
        }
        if (drillCoolDownTimer > 0){
            drillCoolDownTimer -= Time.deltaTime;
        }
        if (fatManCoolDownTimer > 0){
            fatManCoolDownTimer -= Time.deltaTime;
        }
        if (kolokoloCoolDownTimer > 0){
            kolokoloCoolDownTimer -= Time.deltaTime;
        }
        if (lnlCoolDownTimer > 0){
            lnlCoolDownTimer -= Time.deltaTime;
        }
        if (loadLifterCoolDownTimer > 0){
            loadLifterCoolDownTimer -= Time.deltaTime;
        }
        if (mineCoolDownTimer > 0){
            mineCoolDownTimer -= Time.deltaTime;
        }
        if (mk48CoolDownTimer > 0){
            mk48CoolDownTimer -= Time.deltaTime;
        }
        if (neonCoolDownTimer > 0){
            neonCoolDownTimer -= Time.deltaTime;
        }
        if (rayCoolDownTimer > 0){
            rayCoolDownTimer -= Time.deltaTime;
        }
        if (scatterBoxCoolDownTimer > 0){
            scatterBoxCoolDownTimer -= Time.deltaTime;
        }
        if (teslaCoilCoolDownTimer > 0){
            teslaCoilCoolDownTimer -= Time.deltaTime;
        }
        if (toastyCoolDownTimer > 0){
            toastyCoolDownTimer -= Time.deltaTime;
        }
        if (fireMineCoolDownTimer > 0){
            fireMineCoolDownTimer -= Time.deltaTime;
        }
    }

    //CheckWhatSelectionCardWasClickedOn
    public void chooseDefenceObject(string defenceName){
        //ResetWhatObjectHasBeenSelectedIncaseAnotherCardHasBeenSelectedAfterOneWasAlreadySelected
        resetSelectedDefenceObject();
        //SetABooleanToTrueToSpawnInTheObjectThatReleatesToTheSelectionCardClickOn
        //CheckIfTheDrillSelectionCardWasClicked&&ThereIsEnoughOil&&TheCoolDownTimerIsLessThan0
        if (defenceName == "obj_drillSelection" && oil >= drillCost && drillCoolDownTimer <= 0){
            drillSelected = true;
        }
        else if (defenceName == "obj_teslaSelection(Clone)" && oil >= teslaCost && teslaCoilCoolDownTimer <=0){
            teslaSelected = true;
        }
        else if (defenceName == "obj_bobSelection(Clone)" && oil >= bobCost && bobCoolDownTimer <= 0){
            bobSelected = true;
        }
        else if (defenceName == "obj_buzzSelection(Clone)" && oil >= buzzCost && buzzCoolDownTimer <= 0){
            buzzSelected = true;
        }
        else if (defenceName == "obj_scatterBoxSelection(Clone)" && oil >= scatterBoxCost && scatterBoxCoolDownTimer <= 0){
            scatterBoxSelected = true;
        }
        else if (defenceName == "obj_aobSelection(Clone)" && oil >= aobCost && aobCoolDownTimer <= 0){
            aobSelected = true;
        }
        else if (defenceName == "obj_neonSelection(Clone)" && oil >= neonCost && neonCoolDownTimer <= 0){
            neonSelected = true;
        }
        else if (defenceName == "obj_mk48Selection(Clone)" && oil >= mk48Cost && mk48CoolDownTimer <= 0){
            mk48Selected = true;
        }
        else if (defenceName == "obj_raySelection(Clone)" && oil >= rayCost && rayCoolDownTimer <= 0){
            raySelected = true;
        }
        else if (defenceName == "obj_fatManSelection(Clone)" && oil >= fatManCost && fatManCoolDownTimer <= 0){
            fatManSelected = true;
        }
        else if (defenceName == "obj_kolokoloSelection(Clone)" && oil >= kolokoloCost && kolokoloCoolDownTimer <= 0){
            kolokoloSelected = true;
        }
        else if (defenceName == "obj_mineSelection(Clone)" && oil >= mineCost && mineCoolDownTimer <= 0){
            mineSelected = true;
        }
        else if (defenceName == "obj_fireMineSelection(Clone)" && oil >= fireMineCost && fireMineCoolDownTimer <= 0){
            fireMineSelected = true;
        }
        else if (defenceName == "obj_bigBoySelection(Clone)" && oil >= bigBoyCost && bigBoyCoolDownTimer <= 0){
            bigBoySelected = true;
        }
        else if (defenceName == "obj_lnlSelection(Clone)" && oil >= lnlCost && lnlCoolDownTimer <= 0){
            lnlSelected = true;
        }
        else if (defenceName == "obj_toastySelection(Clone)" && oil >= toastyCost && toastyCoolDownTimer <= 0){
            toastySelected = true;
        }
        else if (defenceName == "obj_loadLifterSelection(Clone)" && oil >= loadLifterCost && loadLifterCoolDownTimer <= 0){
            loadlifterSelected = true;
        }
        else{
            //ResetTheBooleansToCreateTheDefenceObjectsOnceOneHasBeenPlaced
            resetSelectedDefenceObject();
        }
    }

    //PlaceTheSelectedObjectOnTheSelectedAreOfTheGrid
    void placeDefenceObjects(){
        //PlaceTheSelectedDefenceObjectInTheLevelAndRemoveTheRequiredAmountOfOil(Points)
        if(drillSelected){
            Instantiate(drill, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= drillCost;
            drillCoolDownTimer = 3;
        }
        if(teslaSelected){
            Instantiate(tesla, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= teslaCost;
            teslaCoilCoolDownTimer = 3;
        }
        if(bobSelected){
            Instantiate(bob, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= bobCost;
            bobCoolDownTimer = 4;
        }
        if(buzzSelected){
            Instantiate(buzz, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= buzzCost;
            buzzCoolDownTimer = 5;
        }
        if(scatterBoxSelected){
            Instantiate(scatterBox, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= scatterBoxCost;
            scatterBoxCoolDownTimer = 6;
        }
        if(aobSelected){
            Instantiate(aob, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= aobCost;
            aobCoolDownTimer = 6;
        }
        if(neonSelected){
            Instantiate(neon, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= neonCost;
            neonCoolDownTimer = 8;
        }
        if(mk48Selected){
            Instantiate(mk48, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= mk48Cost;
            mk48CoolDownTimer = 10;
        }
        if(raySelected){
            Instantiate(ray, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= rayCost;
            rayCoolDownTimer = 15;
        }
        if(fatManSelected){
            Instantiate(fatMan, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= fatManCost;
            fatManCoolDownTimer = 20;
        }
        if(kolokoloSelected){
            Instantiate(kolokolo, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= kolokoloCost;
            kolokoloCoolDownTimer = 3;
        }
        if(mineSelected){
            Instantiate(mine, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= mineCost;
            mineCoolDownTimer = 18;
        }
        if(fireMineSelected){
            Instantiate(fireMine, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= fireMineCost;
            fireMineCoolDownTimer = 20;
        }
        if(bigBoySelected){
            Instantiate(bigBoy, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= bigBoyCost;
            bigBoyCoolDownTimer = 10;
        }
        if(lnlSelected){
            Instantiate(lnl, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= lnlCost;
            lnlCoolDownTimer = 4;
        }
        if(toastySelected){
            Instantiate(toasty, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= toastyCost;
            toastyCoolDownTimer = 6;
        }
        if(loadlifterSelected){
            Instantiate(loadLifter, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            oil -= loadLifterCost;
            loadLifterCoolDownTimer = 8;
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
