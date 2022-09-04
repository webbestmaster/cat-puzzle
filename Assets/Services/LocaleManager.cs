using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocaleManager : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(UpdateLocale());
    }

    private IEnumerator UpdateLocale()
    {

        while (LocalizationSettings.AvailableLocales.Locales.Count < 2)
        {
            Debug.Log("[LocaleManager] wait for LocalizationSettings.AvailableLocales.Locales is defined");
            // Debug.Log(LocalizationSettings.AvailableLocales.Locales.Count);
            yield return new WaitForSeconds(0.1f);            
        }

        Debug.Log("[LocaleManager] set locale");
        // Debug.Log(LocalizationSettings.AvailableLocales.Locales.Count);

        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];
    }
}
