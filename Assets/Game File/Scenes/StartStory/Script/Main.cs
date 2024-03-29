using UnityEngine;
using System.Threading.Tasks;
using DG.Tweening;
using System.Diagnostics;

public class main : MonoBehaviour
{
    // SON
    public AudioSource AudioSource;
    public AudioClip WaterDrop;
    public AudioClip Reveil;
    public AudioClip Ending;

    // CAMERA
    public GameObject cam;

    async void Start() {
        
        ToBlack();
        await Task.Delay(2000);
        AudioSource.PlayOneShot(WaterDrop,1);
        await Task.Delay(2000);
        AudioSource.PlayOneShot(Reveil,0.7f);
    }

    // ANIMATIONS CAMERA
    public void ToBlack() {
            cam.GetComponent<Camera>().DOColor(new Color(0, 0, 0), 1f);
    }

    public void ToGrey() {
        float grey = 1 / 15f; // Une composante des couleurs équivalentes à #111111 ramené sur 1 pour Color()
        cam.GetComponent<Camera>().DOColor(new Color(grey, grey, grey), 2f);
    }

    // SON


}
