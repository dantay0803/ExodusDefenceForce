using UnityEngine;
using System.Collections;

public class scr_levelSpawns : MonoBehaviour {
    //TimerToSpawnEnemyObjectsAtDefinedTimes
    public float levelOneTimer = 98;
    //SetIntialSpawnPointsForEnemyObjects:ToBeRandomizedLaterInEachObject
    int spawnX = -10;
    int spawnY = 0, spawnZ=0;
    //Set enemy objects
    public GameObject obj_fireSpitter, obj_gatherer, obj_hunter, obj_reinforcedWorker, obj_rocky, obj_wheelWorker, obj_worker, obj_wreackingBall, obj_zapper;
    //UseAsDelayToStopWavesSpawingExtraEnemyObjects
    bool waveSpawnDelayOne, waveSpawnDelayTwo = false;
    //DefineAndArrayOfEnemyObjectNames
    string[] enemyObjectNamesArray = { "obj_fireSpitter(Clone)", "obj_gatherer(Clone)", "obj_hunter(Clone)", "obj_reinforcedWorker(Clone)", "obj_rocky(Clone)", "obj_wheelWorker(Clone)", "obj_worker(Clone)", "obj_wreackingBall(Clone)", "obj_zapper(Clone)" };

    //SpawningSystemForLevelone
    void levelOneSpawns(){
        //CheckLevelOneTimerHasNotFinishedItsCountdown
        if (levelOneTimer > 0){
            //CountdownTimerToSpawnInNextWaveOfEnemies
            levelOneTimer -= Time.deltaTime;
        }
        //SpawnInTheEnemyWaveAndAddInADelaySoThatTheyOnlySpawnOnceAt96
        if((int)levelOneTimer == 96 && !waveSpawnDelayOne){
            Instantiate(obj_zapper, new Vector3(spawnX, spawnY, spawnZ), transform.rotation);
            waveSpawnDelayOne = true;
        }
        else if((int)levelOneTimer == 78 && !waveSpawnDelayTwo){
            Instantiate(obj_worker, new Vector3(spawnX, spawnY, spawnZ), transform.rotation);
            Instantiate(obj_worker, new Vector3(spawnX, spawnY, spawnZ), transform.rotation);
            waveSpawnDelayOne = false;
            waveSpawnDelayTwo = true;
        }
        else if((int)levelOneTimer == 68 && !waveSpawnDelayOne){
            Instantiate(obj_worker, new Vector3(spawnX, spawnY, spawnZ), transform.rotation);
            waveSpawnDelayOne = true;
            waveSpawnDelayTwo = false;
        }
        else if ((int)levelOneTimer == 58 && !waveSpawnDelayTwo){
            Instantiate(obj_gatherer, new Vector3(spawnX, spawnY, spawnZ), transform.rotation);
            waveSpawnDelayOne = false;
            waveSpawnDelayTwo = true;
        }
        else if ((int)levelOneTimer == 48 && !waveSpawnDelayOne){
            Instantiate(obj_worker, new Vector3(spawnX, spawnY, spawnZ), transform.rotation);
            waveSpawnDelayOne = true;
            waveSpawnDelayTwo = false;
        }
        else if((int)levelOneTimer == 38 && !waveSpawnDelayTwo){
            Instantiate(obj_wheelWorker, new Vector3(spawnX, spawnY, spawnZ), transform.rotation);
            waveSpawnDelayOne = false;
            waveSpawnDelayTwo = true;
        }
        else if((int)levelOneTimer == 28 && !waveSpawnDelayOne){
            Instantiate(obj_wheelWorker, new Vector3(spawnX, spawnY, spawnZ), transform.rotation);
            waveSpawnDelayOne = true;
            waveSpawnDelayTwo = false;
        }
        else if((int)levelOneTimer == 18 && !waveSpawnDelayTwo){
            Instantiate(obj_worker, new Vector3(spawnX, spawnY, spawnZ), transform.rotation);
            Instantiate(obj_gatherer, new Vector3(spawnX, spawnY, spawnZ), transform.rotation);
            waveSpawnDelayOne = false;
            waveSpawnDelayTwo = true;
        }
        else if((int)levelOneTimer == 10 && !waveSpawnDelayOne){
            Instantiate(obj_gatherer, new Vector3(spawnX, spawnY, spawnZ), transform.rotation);
            waveSpawnDelayOne = true;
            waveSpawnDelayTwo = false;
        }
        else if((int)levelOneTimer == 5 && !waveSpawnDelayTwo){
            Instantiate(obj_wheelWorker, new Vector3(spawnX, spawnY, spawnZ), transform.rotation);
            Instantiate(obj_worker, new Vector3(spawnX, spawnY, spawnZ), transform.rotation);
            waveSpawnDelayOne = false;
            waveSpawnDelayTwo = true;
        }
        else if((int)levelOneTimer == 0 && !waveSpawnDelayOne){
            Instantiate(obj_wheelWorker, new Vector3(spawnX, spawnY, spawnZ), transform.rotation);
            Instantiate(obj_worker, new Vector3(spawnX, spawnY, spawnZ), transform.rotation);
            Instantiate(obj_gatherer, new Vector3(spawnX, spawnY, spawnZ), transform.rotation);
            waveSpawnDelayOne = true;
        }
    }

    //CheckForNoInstancesOfEnimiesInTheLevel
    void checkForWin(){
        if(GameObject.Find("obj_fireSpitter(Clone)") == null &&         GameObject.Find("obj_gatherer(Clone)") == null &&       GameObject.Find("obj_hunter(Clone)") == null &&
           GameObject.Find("obj_reinforcedWorker(Clone)") == null &&    GameObject.Find("obj_rocky(Clone)") == null &&          GameObject.Find("obj_wheelWorker(Clone)") == null &&
           GameObject.Find("obj_worker(Clone)") == null &&              GameObject.Find("obj_wreackingBall(Clone)") == null &&  GameObject.Find("obj_zapper(Clone)") == null){
            //CheckTheNameOfTheLevelAndIfItsTimerIsEqualTo0
            if(Application.loadedLevelName == "scene_levelOne" && levelOneTimer <= 0){
                //ChangeLevel
                Application.LoadLevel("scene_gameWin");
            }    
        }
    }
	
	// Update is called once per frame
	void Update () {
        levelOneSpawns();
        //CheckForNoInstancesOfEnimiesInTheLevel
        checkForWin();
        //CheckIfEnemyObjectsHaveMadeItPastThePlayerDefences 
        checkForLoss();
	}

    //CheckIfEnemyObjectsHaveMadeItPastThePlayerDefences   
    void checkForLoss(){
        //LoopThroughAllTheEnemyObjectNamesToCheckIfAnyHaveReachedTheEndOfTheGrids
        for(int i=0; i<enemyObjectNamesArray.Length; i++){   
            //CheckIfTheEnemyObjectsExistsAndHasReachedTheEndOfEitherGrid
            if(GameObject.Find(enemyObjectNamesArray[i]) != null){
                if((GameObject.Find(enemyObjectNamesArray[i]).transform.position.x < 7 && GameObject.Find(enemyObjectNamesArray[i]).transform.position.x >= 2.5) ||
                    (GameObject.Find(enemyObjectNamesArray[i]).transform.position.x > 7 && GameObject.Find(enemyObjectNamesArray[i]).transform.position.x <= 11.5)){
                    //IfTrueLoadGameOverScene
                    Application.LoadLevel("scene_gameOver");
                }
            }
        }
    }
}
