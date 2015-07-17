using UnityEngine;
using System.Collections;

public class scr_soundManager : MonoBehaviour {
    //If toggleMusic == 0 play music if it == 1 don't play music
    //DefineAudioSourcesToPlaySounds
    public AudioSource sfxSource;
    public AudioSource musicSource;
    //SetIfTheSoundManagerExists
    public static scr_soundManager instance = null;
    //DefineButtonClickAudio
    public AudioClip snd_buttonClick;

	// Use this for initialization
	void Awake() {
        //CheckifThereIsNoInstanceOfTheSoundManagerToPlayAudio
        if(instance == null){
            instance = this;
        }
        //IfSoundManagerInstanceAlreadyExistsDestroyIt
        else if(instance != null){
            Destroy(this.gameObject);
        }
        //StopTheSoundManagerBeingDestroyedOnLoadBetweenScenes
        DontDestroyOnLoad(gameObject);
        playMusic();
    }
	
	//PlayMusic
    public void playMusic(){
        //StopTheMusicIfItIsAlreadyPlaying
        if(musicSource.isPlaying || PlayerPrefs.GetInt("toggleMusic") == 1){
            musicSource.Stop();
        }
        else if(PlayerPrefs.GetInt("toggleMusic") == 0){
            musicSource.Play();
        }
    }

    //ToggleMusic
    public void toggleMusic(){
        Debug.Log("toggle Music");
        //CheckIfMusicIsEnabled
        if (PlayerPrefs.GetInt("toggleMusic") == 0){
            //IfTrueDisableIt
            PlayerPrefs.SetInt("toggleMusic", 1);
        }
        //checkIfMusicIsDisabled
        else if(PlayerPrefs.GetInt("toggleMusic") == 1){
            //IfTrueEnableIt
            PlayerPrefs.SetInt("toggleMusic", 0);
        }
        //UpdateMusic
        playMusic();
    }

    //ToggleSoundEffects
    public void toggleSFX(){
        Debug.Log("toggle sfx");
        //CheckIfSFXIsEnabled
        if (PlayerPrefs.GetInt("toggleSFX") == 0){
            //IfTrueDisableIt
            PlayerPrefs.SetInt("toggleSFX", 1);
        }
        //checkIfMusicIsDisabled
        else if (PlayerPrefs.GetInt("toggleSFX") == 1){
            //IfTrueEnableIt
            PlayerPrefs.SetInt("toggleSFX", 0);
        }
    }

    //PlayButtonClick
    public void playButtonClick(){
        playSingle(snd_buttonClick);  
    }

    //Play the sound effects
    public void playSingle(AudioClip clip){
        //CheckIfSoundEffectsAreEnabledToPlayButtonClick
        if (PlayerPrefs.GetInt("toggleSFX") == 0){
            sfxSource.clip = clip;
            sfxSource.Play();
        }
    }
}
