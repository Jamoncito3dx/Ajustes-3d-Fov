using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CameraFOVAdjuster : MonoBehaviour
{
    [Header("Camera Settings")]
    public Camera targetCamera; // Cámara cuyo FOV será ajustado

    [Header("UI Elements")]
    public Slider fovSlider; // Slider para ajustar el FOV
    public TextMeshProUGUI fovText; // TMP para mostrar el valor del FOV

    [Header("FOV Range")]
    [Range(1, 179)] public float minFOV = 30f; // FOV mínimo
    [Range(1, 179)] public float maxFOV = 120f; // FOV máximo

    private void Start()
    {
        if (targetCamera == null)
        {
            Debug.LogError("No se asignó la cámara en CameraFOVAdjuster.");
            return;
        }

        if (fovSlider != null)
        {
            // Configurar los límites del Slider
            fovSlider.minValue = minFOV;
            fovSlider.maxValue = maxFOV;

            // Inicializar el Slider con el valor actual del FOV de la cámara
            fovSlider.value = targetCamera.fieldOfView;

            // Añadir un listener para detectar cambios en el Slider
            fovSlider.onValueChanged.AddListener(OnFOVSliderChanged);
        }
        else
        {
            Debug.LogError("No se asignó el Slider en CameraFOVAdjuster.");
        }

        // Actualizar el TMP al inicio
        UpdateFOVText(targetCamera.fieldOfView);
    }

    private void OnFOVSliderChanged(float value)
    {
        // Actualizar el FOV de la cámara
        if (targetCamera != null)
        {
            targetCamera.fieldOfView = value;
        }

        // Actualizar el TMP
        UpdateFOVText(value);
    }

    private void UpdateFOVText(float value)
    {
        if (fovText != null)
        {
            fovText.text = $"{Mathf.RoundToInt(value)}°"; // Mostrar el FOV redondeado seguido de °
        }
        else
        {
            Debug.LogError("No se asignó el TextMeshProUGUI en CameraFOVAdjuster.");
        }
    }

    private void OnDestroy()
    {
        // Remover el listener para evitar errores si el objeto es destruido
        if (fovSlider != null)
        {
            fovSlider.onValueChanged.RemoveListener(OnFOVSliderChanged);
        }
    }
}
