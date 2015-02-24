using UnityEngine;
using System.Collections;

public class scr_placeTurrets : MonoBehaviour {
    public bool turretSlected = false;

    //These booleans will keep track of what turret the player has selected and wants to place on the grid
    public bool aobSelected = false;
    public bool bigBoySelected = false;
    public bool bobSelected = false;
    public bool buzzSelected = false;
    public bool drillSelected = false;
    public bool fatManSelected = false;
    public bool kolokol13Selected = false;
    public bool lnlSelected = false;
    public bool loadLifterSelected = false;
    public bool mineSelected = false;
    public bool mk48Selected = false;
    public bool neonSelected = false;
    public bool raySelected = false;
    public bool scatterBoxSelected = false;
    public bool teslaCoilSelected = false;
    public bool toastySelected = false;
    //Store the x and y position of the mouse
    float positionX;
    float positionY; 
    
    void getMouseInput(){
        if (Input.GetMouseButtonDown(0) && turretSlected==true){
            //Get mouse position
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            positionX = mousePosition.x;
            positionY = mousePosition.y;
            //Check if mouse is clicked on left grid
            if (positionX <= 9 && positionY <= -5){
                //Get the X position to spawn turrets
                getLeftGridXPosition();
                //Get the Y position to spawn turrets
                getGridYPosition();   
            }
            else if(positionX >= 17 && positionY <= -5){
                //Get the X position to spawn turrets
                getRightGridXPosition();
                //Get the Y position to spawn turrets
                getGridYPosition();   
            }
        }
    }

    //Get the position to spawn turret on left grid
    void getLeftGridXPosition(){
        if(positionX >= 0 && positionX < 1){
            positionX = 0.5f;
        }
        if (positionX >= 1 && positionX < 2){
            positionX = 1.5f;
        }
        if (positionX >= 2 && positionX < 3){
            positionX = 2.5f;
        }
        if (positionX >= 3 && positionX < 4){
            positionX = 3.5f;
        }
        if (positionX >= 4 && positionX < 5){
            positionX = 4.5f;
        }
        if (positionX >= 5 && positionX < 6){
            positionX = 5.5f;
        }
        if (positionX >= 6 && positionX < 7){
            positionX = 6.5f;
        }
        if (positionX >= 7 && positionX < 8){
            positionX = 7.5f;
        }
        if (positionX >= 8 && positionX < 9){
            positionX = 8.5f;
        }
    }

    //Get the position to spawn turret on right grid
    void getRightGridXPosition(){
        if (positionX >= 17 && positionX < 18){
            positionX = 17.5f;
        }
        if (positionX >= 18 && positionX < 19){
            positionX = 18.5f;
        }
        if (positionX >= 19 && positionX < 20){
            positionX = 19.5f;
        }
        if (positionX >= 20 && positionX < 21){
            positionX = 20.5f;
        }
        if (positionX >= 21 && positionX < 22){
            positionX = 21.5f;
        }
        if (positionX >= 22 && positionX < 23){
            positionX = 22.5f;
        }
        if (positionX >= 23 && positionX < 24){
            positionX = 23.5f;
        }
        if (positionX >= 24 && positionX < 25){
            positionX = 24.5f;
        }
        if (positionX >= 25 && positionX < 26){
            positionX = 25.5f;
        }
    }

    //Get the Y position to spawn turret
    void getGridYPosition(){
        //Get Y position
        if (positionY <= -0 && positionY > -1)
        {
            positionY = -0.5f;
        }
        if (positionY <= -1 && positionY > -2)
        {
            positionY = -1.5f;
        }
        if (positionY <= -2 && positionY > -3)
        {
            positionY = -2.5f;
        }
        if (positionY <= -3 && positionY > -4)
        {
            positionY = -3.5f;
        }
        if (positionY <= -4 && positionY > -5)
        {
            positionY = -4.5f;
        }
        if (positionY <= -5 && positionY > -6)
        {
            positionY = -5.5f;
        }
        if (positionY <= -6 && positionY > -7)
        {
            positionY = -6.5f;
        }
        if (positionY <= -7 && positionY > -8)
        {
            positionY = -7.5f;
        }
        if (positionY <= -8 && positionY > -9)
        {
            positionY = -8.5f;
        }
        //Spawn turret
        spawnTurret();
    }

    //Create new turret
    void spawnTurret(){
        //Create a new instance of the selected turret
        GameObject selectedTurret = null;
        //Create new instance of aob
        if(aobSelected == true){
            selectedTurret = Instantiate(GetComponent<scr_defineTurrets>().aob) as GameObject;
        }
        //Create new instance of big boy
        if(bigBoySelected == true){
            selectedTurret = Instantiate(GetComponent<scr_defineTurrets>().bigBoy) as GameObject;
        }
        //Create new instance of bob
        if(bobSelected == true){
            selectedTurret = Instantiate(GetComponent<scr_defineTurrets>().bob) as GameObject;
            bobSelected = false;
        }
        //Create new instance of buzz
        if(buzzSelected == true){
            selectedTurret = Instantiate(GetComponent<scr_defineTurrets>().buzz) as GameObject;
        }
        //Create new instance of drill
        if(drillSelected == true){
            selectedTurret = Instantiate(GetComponent<scr_defineTurrets>().drill) as GameObject;
        }
        //Create new instance of fat man
        if(fatManSelected == true){
            selectedTurret = Instantiate(GetComponent<scr_defineTurrets>().fatMan) as GameObject;
        }
        //Create new instance of kolokol13
        if(kolokol13Selected == true){
            selectedTurret = Instantiate(GetComponent<scr_defineTurrets>().kolokol13) as GameObject;
        }
        //Create new instance of lnl
        if(lnlSelected == true){
            selectedTurret = Instantiate(GetComponent<scr_defineTurrets>().lnl) as GameObject;
        }
        //Create new instance of load lifter
        if(loadLifterSelected == true){
            selectedTurret = Instantiate(GetComponent<scr_defineTurrets>().loadLifter) as GameObject;
        }
        //Create new instance of mine
        if(mineSelected == true){
            selectedTurret = Instantiate(GetComponent<scr_defineTurrets>().mine) as GameObject;
        }
        //Create new instance of mk48
        if(mk48Selected == true){
            selectedTurret = Instantiate(GetComponent<scr_defineTurrets>().mk48) as GameObject;
        }
        //Create new instance of neon
        if(neonSelected == true){
            selectedTurret = Instantiate(GetComponent<scr_defineTurrets>().neon) as GameObject;
        }
        //Create new instance of ray
        if(raySelected == true){
            selectedTurret = Instantiate(GetComponent<scr_defineTurrets>().ray) as GameObject;
        }
        //Create new instance of scatter box
        if(scatterBoxSelected == true){
            selectedTurret = Instantiate(GetComponent<scr_defineTurrets>().scatterBox) as GameObject;
        }
        //Create new instance of tesla coil
        if(teslaCoilSelected == true){
            selectedTurret = Instantiate(GetComponent<scr_defineTurrets>().teslaCoil) as GameObject;
        }
        //Create new instance of toasty
        if(toastySelected == true){
            selectedTurret = Instantiate(GetComponent<scr_defineTurrets>().toasty) as GameObject;
        }
        //Get starting position of aob turret
        Vector3 objectPosition = selectedTurret.transform.position;
        //Set aob turret position to mouse position
        objectPosition.x = positionX;
        objectPosition.y = positionY;
        selectedTurret.transform.position = objectPosition;
        turretSlected = false;
    }

	// Update is called once per frame
	void Update () {
        //CheckForMouseInput
        getMouseInput();
	}
}
