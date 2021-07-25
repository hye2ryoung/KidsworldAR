using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSelect : MonoBehaviour
{
    private int selectedLanguageIndex;
    private int Language;

    [SerializeField] private Text LanguageName;
    [SerializeField] private List<LanguageSelectObject> LanguageList = new List<LanguageSelectObject>();

    private void Start()
    {
        UpdateLanguageSelection();
    }

    public void LeftArrow()
    {
        selectedLanguageIndex = Language;
        selectedLanguageIndex--;
        if (selectedLanguageIndex < 0)
            selectedLanguageIndex = LanguageList.Count - 1;
        PlayerPrefs.SetInt("Language", selectedLanguageIndex);

        UpdateLanguageSelection();
        //Debug.Log(Language);
    }

    public void RightArrow()
    {
        selectedLanguageIndex = Language;
        selectedLanguageIndex++;
        if (selectedLanguageIndex == LanguageList.Count)
            selectedLanguageIndex = 0;
        PlayerPrefs.SetInt("Language", selectedLanguageIndex);

        UpdateLanguageSelection();
        //Debug.Log(Language);
    }

    private void UpdateLanguageSelection()
    {
        Language = PlayerPrefs.GetInt("Language");
        LanguageName.text = LanguageList[Language].LanguageName;
        
    }


    [System.Serializable]
    public class LanguageSelectObject
    {
        public string LanguageName;
    }
}
