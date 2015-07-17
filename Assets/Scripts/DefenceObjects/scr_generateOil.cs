using UnityEngine;
using System.Collections;

public class scr_generateOil : MonoBehaviour {
    //SetHowMuchOil/ManyPointsAreGenerated
    int oilGenerated = 25; 
    //SetHowLongItTakesToGenerateOil/PointsAndDefineATimer
    float oilGenerationTimer = 2, countDownTimer = 2;

    // Update is called once per frame
    void Update(){
        //CheckIfTimerHasStopped
        if(countDownTimer <= 0){
            //resetTimer
            countDownTimer = oilGenerationTimer;
            //AddTheOilGeneratedToTheOverAllOilCountOfThePlayer
            scr_placeDefenceObjects.instance.oil += oilGenerated;
            //UpdateTheScoreDisplay
            scr_displayScore.instance.displayOil(scr_placeDefenceObjects.instance.oil);
        }
        //CheckIfTimerHasNotStopped
        else if(countDownTimer > 0){
            //RunTimer
            countDownTimer -= Time.deltaTime;
        }
    }
}
