using System.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    AudioSource audioSource;
    public async void PlayPressed() {
        audioSource.DOFade(0,0.5f);
        await Task.Delay(500);
        SceneManager.LoadSceneAsync("StartStory");
    }

    public void QuitPressed() {
        Application.Quit();
    }
}
