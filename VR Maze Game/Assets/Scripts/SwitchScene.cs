using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SwitchScene : MonoBehaviour, IPointerClickHandler
{
    public Button yourButton;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }

    public void OnPointerClick(PointerEventData eventData){
        Debug.Log("Clicked button");
        SceneManager.LoadScene (sceneName: "UI-PlayerName");
    }

    // On click
    public void TaskOnClick()
    {
        Debug.Log ("You have clicked the button!");
        SceneManager.LoadScene (sceneName: "UI-PlayerName");
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
