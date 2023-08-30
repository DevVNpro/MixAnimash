using System;
using System.Collections;
using Projects.Script.Manager;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Projects.Script.GenScripts
{
    public class ButtonManagerGenScene : MonoBehaviour
    {

        [SerializeField] private GameObject setting;
    

        public void LoadSceneBattle()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            DataAnimal.Instance.DeleteNamedata();
            SceneControl.Instance.LoadScene(5);
        }
        
        

        public void LoadCreateAnimal()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            DataAnimal.Instance.DeleteNamedata();
           SceneControl.Instance.BackScene();
        }

        public void BackMenuClick()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            DataAnimal.Instance.DeleteNamedata();
            SceneControl.Instance.MenuScene();
        }

        public void OpenSetting()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            setting.SetActive(true);
        }

        public void CloseSetting()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            setting.SetActive(false);
        }
  

    }
}
