using UnityEngine;
using UnityEngine.UI;
public class CountScore : MonoBehaviour {

    public Transform player;
    public Text scoreboard;
    // Update is called once per frame
    void Update()
    {
        scoreboard.text = (player.position.z/25).ToString("0");
    }
}
