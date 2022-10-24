using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
/* links
 * Settings : https://www.flaticon.com/free-icon/settings_563541?term=settings&page=1&position=7&page=1&position=7&related_id=563541&origin=tag
 * Wallpaper: https://www.pinterest.com/pin/809170258025259451/
 * Mail :
 * Search Engine :
 * Social Network :
 * 
 * 
 * 
 */

public class Hotbar : MonoBehaviour
{

    [SerializeField] private TMP_Text TMP_battery;
    [SerializeField] private TMP_Text TMP_time;
    [SerializeField] private TMP_Text TMP_wifi;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayBattery();
        DisplayTime();
        DisplayWifi();
    }

    private void DisplayWifi()
    {
        
    }

    private void DisplayBattery()
    {
        float battery = SystemInfo.batteryLevel * 100; // 100 for porcentages reasons
        TMP_battery.text = battery + "%";
    }

    private void DisplayTime()
    {
        DateTime time = DateTime.Now;
        TMP_time.text = time.ToString("HH:mm");
    }
}
