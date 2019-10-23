using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerupTextScript : MonoBehaviour
{
    private string powerup;

    private Text powerUpText;

    // Start is called before the first frame update
    void Start()
    {
        powerup = " ";

        powerUpText = GetComponent<Text>();

        powerUpText.text = powerup;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GrantShrink()
    {
        powerup = "S";

        powerUpText.text = powerup;
    }

    public void RemovePowerUp()
    {
        powerup = " ";

        powerUpText.text = powerup;
    }
}
