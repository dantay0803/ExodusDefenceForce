using UnityEngine;
using System.Collections;

public class scr_toggleAudio : MonoBehaviour {
    //DefineAudioClips
    //ButtonClick
    public AudioClip snd_buttonClick;

    public void toggleAudio(){
        //ToggleSoundEffectsOnClick
        if(this.gameObject.name == "obj_toggleSFXButton"){
            scr_soundManager.instance.toggleSFX();
        }
        //ToggleMusicOnClick
        else if(this.gameObject.name == "obj_toggleMusicButton"){
            scr_soundManager.instance.toggleMusic();
        }
        //Play the button click clip using the sound manager object
        scr_soundManager.instance.playSingle(snd_buttonClick);
    }
}
