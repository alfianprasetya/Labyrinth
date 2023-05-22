using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionsPanel : MonoBehaviour
{
   [SerializeField] AudioManager audioManager;
   [SerializeField] Toggle muteToggle;
   [SerializeField] Slider bgmSlider;
   [SerializeField] Slider sfxSlider;
   [SerializeField] TMP_Text bgmVolText;
   [SerializeField] TMP_Text sfxVolText;

   private void OnEnable()
    {
        
        muteToggle.isOn = audioManager.IsMute;
        if(PlayerPrefs.HasKey("bgmVolume"))
          bgmSlider.value = PlayerPrefs.GetFloat("bgmVolume");
          // Debug.Log(PlayerPrefs.GetFloat("bgmVolume"));
            
     //    bgmSlider.value = audioManager.BgmVolume;
        if(PlayerPrefs.HasKey("sfxVolume"))
          sfxSlider.value = PlayerPrefs.GetFloat("sfxVolume");

     //    sfxSlider.value = audioManager.SfxVolume;
        SetBgmVolText(bgmSlider.value);
        SetSfxVolText(sfxSlider.value);
   }

   public void SetBgmVolText(float value)
   {
        bgmVolText.text = Mathf.RoundToInt(value * 100).ToString();
   }

   public void SetSfxVolText(float value)
   {
        sfxVolText.text = Mathf.RoundToInt(value * 100).ToString();
   }
}
