using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class HUDController : MonoBehaviour
{

    public Slider healthBar;
    public Slider armorBar;


    public TMP_Text ammoText;
    public TMP_Text weaponText;


    public GameObject reloadIndicator;



    private HUDData data;



    private void Awake()
    {
        data = new HUDData();

        data.health = 100;
        data.armor = 100;

        data.currentAmmo = 30;
        data.maxAmmo = 120;

        data.weaponName = "ASSAULT RIFLE";

        UpdateHUD();
    }



    public void UpdatePlayerHUD(HUDData newData)
    {
        data = newData;

        UpdateHUD();
    }



    void UpdateHUD()
    {

        healthBar.value =
            data.health;


        armorBar.value =
            data.armor;



        ammoText.text =
            data.currentAmmo +
            " / " +
            data.maxAmmo;



        weaponText.text =
            data.weaponName;



        reloadIndicator.SetActive(
            data.isReloading
        );
    }



    public void SetHealth(int value)
    {
        data.health = value;
        UpdateHUD();
    }



    public void SetArmor(int value)
    {
        data.armor = value;
        UpdateHUD();
    }



    public void SetAmmo(
        int current,
        int max)
    {
        data.currentAmmo = current;
        data.maxAmmo = max;

        UpdateHUD();
    }

}
