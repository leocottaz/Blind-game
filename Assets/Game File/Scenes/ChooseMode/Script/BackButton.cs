using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {
    public void BackPressed() {
        SceneManager.LoadSceneAsync("MenuScene");
    }
}
