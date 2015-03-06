using UnityEngine;
using System.Collections;

public class scr_enemyCollisionProjectilesAndMines : MonoBehaviour
{
    //Define the blast radius object
    public GameObject blastRadiusObject;

    //Set the damage values of the turrets projectiles and mines
    //Projectiles
    float aobBulletDamage = 10; //10 Damage per projectile fires 2 - full grid
    float bobBulletDamage = 10; //Kill basic 100 health enemy in 10 hits - full grid
    float buzzSawDamage = 20; //Fire rate twice as slow as B.O.B  - half grid
    float fatManRocketDamage = 250; //Explosion radius same damage - full grid
    float mk48GrenadeDamage = 80; //Explosion radius same damage - third of grid
    float neonBeamDamage = 25; //Fires two projectiles - half grid
    float rayBeamDamage = 250; // Full
    float scatterboxBulletDamage = 40; // Half grid
    float toastyFlamesDamage = 10;
    //Mines
    float mineDamage = 175;

    //Big Boy Blast Radius - 80
    //Fat Man Blast Radius - 125

    //Save enemy object speed
    float enemySpeed;
    //Sets how long enemy should freeze for
    float timer = 3;
    //Used to pause enemy when hit with lnl bullet
    bool lnlBulletHit = false;
    //USed to half enemy speed when hit kolokol13 mine
    bool kolokol13Hit = false;
    //Used to apply tick damage after being hit by Toasty flames
    bool hitByToastyFlames = false;
    //Hold the random amount of tick damage after being hit by Toasty flames
    int randomFireDamageValue = 0;

    //The update function will be used to run the timed player attack effects on the enimies
    void Update()
    {
        //If enemy has hit L.N.L bullet execute L.N.L effect
        if (lnlBulletHit == true)
        {
            lnlBulletEffect();
        }
        //If enemy has hit Kolokol13 mine execute the mine's effect
        if (kolokol13Hit == true)
        {
            kolokol13Effect();
        }
        //If enemy is hit by Toasty flames execute the fire effect
        if (hitByToastyFlames == true)
        {

        }
    }

    //Collision with Toasty flames
    void toastyFireEffect()
    {
        //Counts down the time
        timer -= Time.deltaTime;
        //Apply tick damage at each second
        switch ((int)timer)
        {
            case 0:
                this.GetComponent<scr_checkObjectsHealth>().objectHealth -= randomFireDamageValue;
                break;
            case 1:
                this.GetComponent<scr_checkObjectsHealth>().objectHealth -= randomFireDamageValue;
                break;
            case 2:
                this.GetComponent<scr_checkObjectsHealth>().objectHealth -= randomFireDamageValue;
                break;
        }
        //Reset timer
        if (timer <= 0)
        {
            timer = 3;
            //Remove Toasty effects
            hitByToastyFlames = false;
        }
    }

    //Collision with L.N.L bullet effect
    void lnlBulletEffect()
    {
        //Sets enemy objects speed = 0
        this.GetComponent<scr_enemyMovement>().movementSpeed = 0;
        //Counts down the time
        timer -= Time.deltaTime;
        //Reset timer
        if (timer <= 0)
        {
            //Reset enemy movement speed
            this.GetComponent<scr_enemyMovement>().movementSpeed = enemySpeed;
            //Remove L.N.L effect
            lnlBulletHit = false;
            timer = 3;
        }
    }

    //Collision with kolokol13 min
    void kolokol13Effect()
    {
        //Half the enemy's current speed
        this.GetComponent<scr_enemyMovement>().movementSpeed = enemySpeed / 2;
        //Count down timer
        timer -= Time.deltaTime;
        //If timer is <= 0
        if (timer <= 0)
        {
            //Reset enemy movement speed
            this.GetComponent<scr_enemyMovement>().movementSpeed = enemySpeed;
            //Remove Kolokol-13 effect
            kolokol13Hit = false;
            //Reset Timer
            timer = 3;
        }
    }

    //Enemies colliding with player defence attacks
    void OnTriggerEnter2D(Collider2D other)
    {
        //Only execute L.N.L bullet collison on enimies that is not the Fire Spitter
        if (this.gameObject.name != "obj_fireSpitter(Clone)" && other.gameObject.name == "obj_lnlBullet(Clone)" && timer == 3)
        {
            //Get current speed of enemy
            enemySpeed = this.GetComponent<scr_enemyMovement>().movementSpeed;
            //Run function below to stop enemy for certain amount of time
            lnlBulletHit = true;
        }
        //Check for collision with enemy object
        switch (other.gameObject.name)
        {
            //Collision with A.O.B bullet
            case "obj_aobBullet(Clone)":
                this.GetComponent<scr_checkObjectsHealth>().objectHealth -= aobBulletDamage;
                break;
            //Collision with B.O.B bullet
            case "obj_bobBullet(Clone)":
                this.GetComponent<scr_checkObjectsHealth>().objectHealth -= bobBulletDamage;
                break;
            //Collision with buzz saw
            case "obj_buzzSaw(Clone)":
                this.GetComponent<scr_checkObjectsHealth>().objectHealth -= buzzSawDamage;
                break;
            //Collision with MK48 Grenade
            case "obj_mk48Grenade(Clone)":
                this.GetComponent<scr_checkObjectsHealth>().objectHealth -= mk48GrenadeDamage;
                break;
            //Collision with N.E.O.N beam
            case "obj_neonBeam(Clone)":
                this.GetComponent<scr_checkObjectsHealth>().objectHealth -= neonBeamDamage;
                break;
            //Collision with R.A.Y beam
            case "obj_rayBeam(Clone)":
                this.GetComponent<scr_checkObjectsHealth>().objectHealth -= rayBeamDamage;
                break;
            //Collison with Scatter Box bullete
            case "obj_scatterBoxBullet(Clone)":
                this.GetComponent<scr_checkObjectsHealth>().objectHealth -= scatterboxBulletDamage;
                break;
            //Collision with Toasty Flames
            case "obj_toastyFlames(Clone)":
                this.GetComponent<scr_checkObjectsHealth>().objectHealth -= toastyFlamesDamage;
                hitByToastyFlames = true;
                //Select random damage effect
                randomFireDamageValue = Random.Range(1, 4);
                break;
            case "obj_fatManRocket":
                this.GetComponent<scr_checkObjectsHealth>().objectHealth -= fatManRocketDamage;
                //Create instances of the blast radius on every space along the rockets Y posiiton
                Instantiate(blastRadiusObject, new Vector3(-0.5f, other.transform.position.y, other.transform.position.z), other.transform.rotation);
                Instantiate(blastRadiusObject, new Vector3(0.5f, other.transform.position.y, other.transform.position.z), other.transform.rotation);
                Instantiate(blastRadiusObject, new Vector3(1.5f, other.transform.position.y, other.transform.position.z), other.transform.rotation);
                Instantiate(blastRadiusObject, new Vector3(2.5f, other.transform.position.y, other.transform.position.z), other.transform.rotation);
                Instantiate(blastRadiusObject, new Vector3(3.5f, other.transform.position.y, other.transform.position.z), other.transform.rotation);
                Instantiate(blastRadiusObject, new Vector3(4.5f, other.transform.position.y, other.transform.position.z), other.transform.rotation);
                Instantiate(blastRadiusObject, new Vector3(5.5f, other.transform.position.y, other.transform.position.z), other.transform.rotation);
                Instantiate(blastRadiusObject, new Vector3(6.5f, other.transform.position.y, other.transform.position.z), other.transform.rotation);
                Instantiate(blastRadiusObject, new Vector3(7.5f, other.transform.position.y, other.transform.position.z), other.transform.rotation);
                break;
            //Collision with mine
            case "obj_mine(Clone)":
                this.GetComponent<scr_checkObjectsHealth>().objectHealth -= mineDamage;
                break;
            //Collision with big boy blast radius
            case "obj_bigBoyBlastRadius(Clone)":
                this.GetComponent<scr_checkObjectsHealth>().objectHealth -= mineDamage;
                break;
            //Collision with Kolokol-13
            case "obj_kolokol13(Clone)":
                kolokol13Hit = true;
                //Save enemy object speed
                enemySpeed = this.GetComponent<scr_enemyMovement>().movementSpeed;
                break;
            default:
                break;
        }
        //Check for collision with big boy mine
        if (other.gameObject.name == "obj_bigBoy(Clone)")
        {
            //Apply damage
            this.GetComponent<scr_checkObjectsHealth>().objectHealth -= mineDamage;
            //Check mine is not on the first X space to create an instance of the blast radius object in front of its position
            if (other.gameObject.transform.position.x != -0.5)
            {
                Instantiate(blastRadiusObject, new Vector3(other.transform.position.x - 1, other.transform.position.y, other.transform.position.z), other.transform.rotation);
            }
            //Check mine is not on the last X space to create an instance of the blast radius object behinds its position
            if (other.gameObject.transform.position.x != 7.5)
            {
                Instantiate(blastRadiusObject, new Vector3(other.transform.position.x + 1, other.transform.position.y, other.transform.position.z), other.transform.rotation);
            }
            //Check mine is not on the top Y space to create an instance of the blast radius object above its position
            if (other.gameObject.transform.position.y != -5.5)
            {
                Instantiate(blastRadiusObject, new Vector3(other.transform.position.x, other.transform.position.y + 1, other.transform.position.z), other.transform.rotation);
            }
            //Check mine is not on the bottom Y space to create an instance of the blast radius object below its position
            if (other.gameObject.transform.position.y != -9.5)
            {
                Instantiate(blastRadiusObject, new Vector3(other.transform.position.x, other.transform.position.y - 1, other.transform.position.z), other.transform.rotation);
            }
        }
    }
}