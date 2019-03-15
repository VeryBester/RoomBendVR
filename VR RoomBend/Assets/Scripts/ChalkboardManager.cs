using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChalkboardManager : MonoBehaviour
{

    public Text titleText;
    public Text bodyText;
    private int soundsLocated;
    private int totalSounds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetSoundsLocated(int sounds)
    {
        soundsLocated = sounds;
    }

    public void SetTotalSounds(int sounds)
    {
        totalSounds = sounds;
    }

    public void UpdateGameMessage()
    {
        titleText.text = "RoomBend\nVR\n---------";
        bodyText.text = "\nHow to play:\n\nLocate and throw objects around the room to make music!\n\n"+soundsLocated+"/"+totalSounds+"\nSounds Located";
    }

    public void ShowCustomMessage(string title, string body)
    {
        titleText.text = title;
        bodyText.text = body;
    }
}
