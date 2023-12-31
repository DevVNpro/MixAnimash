using System;
using Projects.Script.Manager;
using UnityEngine;
using UnityEngine.UI;
namespace Projects.Script.Menu
{
    public class ManagerButtonMenu : MonoBehaviour
    {

        [SerializeField] private GameObject popUpBlockAds;
        [SerializeField] private GameObject Setting;

        public void LoadSetting()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            Setting.SetActive(true);
        }

        public void CloseSetingg()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            Setting.SetActive(false);
        }

        public void LoadSceneTriple()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            SceneControl.Instance.LoadScene(4);
        }

        public void LoadScenePVP()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            SceneControl.Instance.LoadScene(5);
        }

        public void NextScene()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            SceneControl.Instance.LoadNextScene();
        }

        public void SaveScene()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            SceneControl.Instance.LoadScene(3);
        }

        public void OpenPopUpBlockAds()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            popUpBlockAds.SetActive(true);
        }

        public void ClosePopUpBlackAds()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            popUpBlockAds.SetActive(false);
        }



    }
}
