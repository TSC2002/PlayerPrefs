using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private TMP_Dropdown resolution;

    private void Start()
    {
        MostrarEnPantalla();
    }

    public void SetVolumen()
    {
        PlayerPrefs.SetFloat("Volumen", volumeSlider.value);
    }

    public void SetName()
    {
         PlayerPrefs.SetString("Nombre", nameInput.text);
    }

    public void SetResolution()
    {
        PlayerPrefs.SetInt("Resolucion", resolution.value);
    }

    public void ResetDefault()
    {
        PlayerPrefs.DeleteAll();
        MostrarEnPantalla();
    }

    public void MostrarEnPantalla()
    {
        nameInput.text = PlayerPrefs.GetString("Nombre");
        volumeSlider.value = PlayerPrefs.GetFloat("Volumen");
        resolution.value = PlayerPrefs.GetInt("Resolucion");
    }
}
