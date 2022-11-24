using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
/* links
 * Settings : https://www.flaticon.com/free-icon/settings_563541?term=settings&page=1&position=7&page=1&position=7&related_id=563541&origin=tag
 * Mail : https://www.flaticon.com/free-icon/email_561127?term=mail&page=1&position=5&page=1&position=5&related_id=561127&origin=search
 * Search Engine : https://www.flaticon.com/free-icon/search_3905267?term=search%20engine&page=1&position=16&page=1&position=16&related_id=3905267&origin=search
 * Social Network : https://www.flaticon.com/free-icon/network_149181?term=social%20network&page=1&position=14&page=1&position=14&related_id=149181&origin=search
 * Hacker : https://www.flaticon.com/free-icon/hacker_1320457?term=hacker&page=1&position=3&page=1&position=3&related_id=1320457&origin=search
 * Life : https://www.flaticon.com/free-icon/personal-information_3076333?term=personal%20data&page=1&position=7&page=1&position=7&related_id=3076333&origin=search
 * Wallpaper : They all come from my personnal Gallery
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
