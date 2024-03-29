using UnityEngine;

public class DontDestroy : MonoBehaviour {
    private static DontDestroy instance;
    
    private void Awake() {
        if (instance != null) {
            // Y'a 2 objets, faut supprimer le nouveau
            Destroy(gameObject);
            return;
        }
    
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
