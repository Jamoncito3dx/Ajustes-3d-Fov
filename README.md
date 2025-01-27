# Unity Camera FOV Adjuster

Este proyecto contiene un script de Unity llamado `CameraFOV` que permite ajustar el campo de visión (FOV) de una cámara en tiempo real utilizando un `Slider` y un `TextMeshProUGUI` para mostrar el valor actual del FOV.

## 📋 Características

- Ajusta dinámicamente el campo de visión (FOV) de una cámara en tiempo real.
- Configuración flexible de los límites del FOV mediante parámetros expuestos en el Inspector.
- Muestra el valor del FOV actualizado mediante un texto de `TextMeshPro`.

## 🛠️ Requisitos

- **Unity** (versión recomendada: 2021.3 o superior).
- **TextMeshPro**: Asegúrate de que el paquete TextMeshPro esté instalado en tu proyecto de Unity.

## 🚀 Cómo usar el script

1. **Agregar el script al proyecto:**
   - Copia el archivo `CameraFOV.cs` y colócalo en la carpeta `Scripts` de tu proyecto de Unity.

2. **Configurar los elementos en la escena:**
   - **Cámara**: Asigna la cámara cuyo FOV deseas ajustar al campo `targetCamera`.
   - **Slider**:
     - Crea un `Slider` en la interfaz gráfica.
     - Configura sus valores mínimos y máximos automáticamente ajustándolos desde el script.
     - Asigna el `Slider` al campo `fovSlider`.
   - **TextMeshPro**:
     - Crea un objeto de texto usando `TextMeshPro`.
     - Asigna el texto TMP al campo `fovText`.

3. **Configurar el rango del FOV:**
   - Define los valores mínimos y máximos del FOV en los campos `minFOV` y `maxFOV` en el Inspector.

4. **Ejecutar el proyecto:**
   - Al iniciar el juego, el `Slider` reflejará el valor actual del FOV de la cámara.
   - Ajusta el `Slider` para cambiar el FOV. El valor se mostrará actualizado en el texto TMP.

## 📂 Estructura del proyecto

```plaintext
UnityCameraFOVAdjuster/
├── CameraFOV.cs             # Script principal para ajustar el FOV de la cámara.
├── README.md                # Documentación del proyecto.
