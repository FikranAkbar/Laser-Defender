using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI healthText;
    Player playerStats;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = FindObjectOfType<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = playerStats.GetHealth().ToString();
    }
}
