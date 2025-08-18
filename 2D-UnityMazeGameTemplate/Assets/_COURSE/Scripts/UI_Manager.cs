using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    //////// Declare class as Singleton
    ////////////////////////////////////////////
    public static UI_Manager Instance { get; private set; }
    private void Awake(){
        if (Instance != null && Instance != this){
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }





    public Text TXT_Score;
    public void _SetText(string NewText) {
        TXT_Score.text = NewText;
    }
}
