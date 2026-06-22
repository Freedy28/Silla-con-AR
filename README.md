
##Licencias Unity
# Guía de Licencias de Unity y Publicación en Google Play Store (2026)

Este repositorio contiene una guía detallada en formato `README.md` orientada a desarrolladores independientes, estudiantes y profesionales sobre el estado actual de las licencias de Unity y los costos asociados con la publicación de aplicaciones en la Play Store de Google.

---

## 📋 Índice
1. [Licencias de Unity](#1-licencias-de-unity)
2. [Publicación en Google Play Store](#2-publicación-en-google-play-store)
3. [Requisitos Técnicos Obligatorios (2026)](#3-requisitos-técnicos-obligatorios-2026)
4. [Preguntas Frecuentes (FAQ)](#4-preguntas-frecuentes-faq)

---

## 1. Licencias de Unity

Tras la eliminación definitiva de la polémica tarifa por instalación (*Runtime Fee*) a finales de 2024, Unity opera bajo un modelo de suscripción anual claro y predecible para este año 2026.

### Tabla Comparativa de Licencias

| Nivel de Licencia | Costo Anual | Límite de Ingresos / Financiación (Anual) | Características Clave |
| :--- | :--- | :--- | :--- |
| **Unity Personal** | **Gratis ($0 USD)** | Menos de $200,000 USD | Motor completo. **Sin pantalla de carga obligatoria** ("Made with Unity") desde el lanzamiento de Unity 6. |
| **Unity Pro** | $2,310 USD / asiento | Obligatorio si superas los $200,000 USD | Soporte premium, acceso al código fuente y versiones de soporte extendido (LTS). |
| **Unity Enterprise** | Personalizado | Estudios a gran escala | Herramientas avanzadas de automatización y soporte arquitectónico directo del equipo de Unity. |
| **Unity Industry** | Personalizado | Más de $1,000,000 USD (No videojuegos) | Para aplicaciones industriales, arquitectónicas, médicas o automotrices. |

💡 **Regla de oro para el desarrollador indie:** Mientras tus ingresos brutos o financiamiento total de los últimos 12 meses sean menores a **$200,000 USD**, puedes usar **Unity Personal de forma gratuita**, publicar comercialmente y retener el 100% de tus ganancias sin pagar regalías.

---

## 2. Publicación en Google Play Store

### ¿Es posible subir aplicaciones de manera gratuita?
**No al 100%.** Aunque puedes desarrollar el juego completo sin gastar un solo centavo en software, la distribución en la plataforma oficial de Google requiere una inversión inicial para abrir la consola de desarrollador.

### Desglose de Costos y Comisiones

1. **Cuota de Registro Inicial ($25 USD):**
   * Es un **pago único de por vida**.
   * No es una suscripción anual (a diferencia del programa de Apple que cuesta $99 USD cada año).
   * Permite crear un perfil de desarrollador y subir un número **ilimitado** de juegos y aplicaciones sin costos adicionales por almacenamiento o actualizaciones.

2. **Comisión por Monetización (Modelo del 15%):**
   * **Juegos 100% Gratuitos:** Si tu app no tiene anuncios ni compras internas, Google **no te cobrará nada** por las descargas de tus usuarios.
   * **Juegos de Pago o con Microtransacciones:** Si vendes el juego o incluyes compras integradas (*In-App Purchases*), Google retiene una comisión reducida del **15%** sobre el primer millón de dólares en ingresos anuales. Al superar ese límite, la comisión asciende al 30%.

---

## 3. Requisitos Técnicos Obligatorios (2026)

Para que la consola de Google Play acepte tu archivo compilado desde Unity, debes asegurar el cumplimiento de las siguientes directivas en los *Player Settings*:

* **Target API Level:** Google Play exige como objetivo mínimo **Android 16 (API Level 36)** para nuevos lanzamientos este año.
* **Formato de Entrega:** Es obligatorio exportar en formato **Android App Bundle (`.aab`)**. Los archivos tradicionales `.apk` ya no se admiten para publicaciones en producción.
* **Firma de la Aplicación:** Debes generar y configurar un *Keystore* seguro dentro de Unity para firmar digitalmente el paquete antes de subirlo.
* **Verificación de Identidad:** Google solicita una verificación estricta de identidad para cuentas nuevas (requiere identificación oficial o número D-U-N-S en caso de registrarse como organización).

---

## 4. Preguntas Frecuentes (FAQ)

**¿Unity me cobrará regalías si mi juego se vuelve viral y tiene millones de descargas?**
No. El *Runtime Fee* está completamente muerto. Solo estás obligado a actualizar a una licencia Pro si el total de tus ingresos de la empresa o financiamiento supera el umbral de los $200k USD anuales.

**¿Puedo publicar mi juego hecho con la licencia Personal y cobrar por él?**
Sí. Puedes vender tu juego, añadirle anuncios de Unity Ads/AdMob o incluir microtransacciones utilizando la versión gratuita de Unity, siempre y cuando te mantengas debajo del límite de ingresos de la licencia Personal.

**¿Cuánto tarda Google en aprobar mi primera aplicación?**
El proceso de revisión para cuentas de desarrollador nuevas suele tardar entre **3 y 7 días hábiles** debido a los controles de seguridad e identidad vigentes.
"""


# Silla con AR

Proyecto de **Realidad Aumentada en Unity** que utiliza **Vuforia Engine** para detectar una imagen objetivo (`ImageTarget`) mediante la cámara del dispositivo. Cuando el marcador es reconocido, la aplicación muestra personajes 3D en posiciones predeterminadas y reproduce una animación de sentado.

---

## Tabla de contenido

1. [Descripción general](#descripción-general)
2. [Tecnologías utilizadas](#tecnologías-utilizadas)
3. [Estructura del proyecto](#estructura-del-proyecto)
4. [Escenas del proyecto](#escenas-del-proyecto)
5. [Funcionamiento general](#funcionamiento-general)
6. [Scripts del proyecto](#scripts-del-proyecto)
7. [Animaciones y modelos 3D](#animaciones-y-modelos-3d)
8. [Requisitos para abrirlo](#requisitos-para-abrirlo)
9. [Cómo ejecutar el proyecto en Unity](#cómo-ejecutar-el-proyecto-en-unity)
10. [Cómo compilar para Android](#cómo-compilar-para-android)
11. [Configuración importante de Vuforia](#configuración-importante-de-vuforia)
12. [Problemas comunes y soluciones](#problemas-comunes-y-soluciones)
13. [Notas sobre Git LFS](#notas-sobre-git-lfs)
14. [Licencia](#licencia)

---

## Descripción general

El proyecto **Silla con AR** es una aplicación de Realidad Aumentada basada en reconocimiento de imagen. Su objetivo principal es:

- Abrir la cámara del dispositivo.
- Detectar una imagen objetivo mediante Vuforia.
- Usar esa imagen como referencia espacial en el mundo real.
- Mostrar personajes 3D sobre el marcador.
- Posicionar cada personaje en un punto definido.
- Activar una animación de sentado al detectar el marcador.

En la escena principal se observa una lógica centrada en un `ImageTarget`. Cuando Vuforia detecta la imagen, se ejecuta un evento `OnTargetFound`, el cual llama al método `OnMarkerFound()` del script `SentarseAR_Grupo`. Ese método hace visibles los modelos 3D, los acomoda en sus respectivos puntos de aparición y dispara el trigger de animación `SentarTrigger`.

---

## Tecnologías utilizadas

| Tecnología | Uso dentro del proyecto |
|---|---|
| Unity | Motor principal del proyecto. |
| Unity 6 | Versión usada por el proyecto: `6000.3.9f1`. |
| C# | Lenguaje utilizado para los scripts. |
| Vuforia Engine | Reconocimiento de imágenes y funcionamiento AR. |
| Android | Plataforma configurada para compilación móvil. |
| Git LFS | Manejo de archivos pesados como modelos FBX, texturas, imágenes y paquetes. |

---

## Estructura del proyecto

La estructura principal es la siguiente:

```text
Silla-con-AR-main/
├── Assets/
│   ├── Common/
│   │   └── Icons/
│   │       ├── Android/
│   │       ├── iOS/
│   │       └── UWP/
│   ├── Editor/
│   │   ├── Migration/
│   │   │   └── AddVuforiaEnginePackage.cs
│   │   └── Vuforia/
│   │       └── ForPrint/
│   ├── Resources/
│   │   └── VuforiaConfiguration.asset
│   ├── SamplesResources/
│   │   ├── AugmentationAssets/
│   │   ├── InstantImageTarget/
│   │   └── Scenes/
│   │       └── 0-Main.unity
│   ├── Scenes/
│   │   ├── Silla.unity
│   │   ├── PedirCamers.cs
│   │   ├── SentarseAR_Directo.cs
│   │   ├── SentarseAR_Grupo.cs
│   │   ├── ControladorPersonaje.controller
│   │   ├── *.fbx
│   │   └── texturas / imágenes
│   ├── Settings/
│   └── _Recovery/
│       └── 0.unity
├── Packages/
│   ├── manifest.json
│   ├── packages-lock.json
│   └── com.ptc.vuforia.engine-11.4.4.tgz
├── ProjectSettings/
├── QCAR/
├── LICENSE
└── README.md
```

### Carpetas más importantes

#### `Assets/Scenes/`
Contiene la escena principal `Silla.unity`, los scripts propios del proyecto, modelos 3D, texturas, controlador de animación y la imagen usada como marcador.

#### `Assets/Resources/`
Contiene `VuforiaConfiguration.asset`, archivo donde se almacena la configuración de Vuforia, incluyendo la licencia de la aplicación.

#### `Assets/SamplesResources/`
Contiene recursos de ejemplo de Vuforia, como la escena `0-Main.unity`, modelos y recursos del astronauta. Esta escena aparece en Build Settings, pero está deshabilitada.

#### `Assets/Editor/Migration/`
Contiene un script de editor importado por Vuforia para gestionar la instalación o actualización del paquete de Vuforia.

#### `Packages/`
Contiene el manifiesto de paquetes de Unity y una referencia local a `com.ptc.vuforia.engine-11.4.4.tgz`.

---

## Escenas del proyecto

### Escena principal: `Assets/Scenes/Silla.unity`

Es la escena activa en Build Settings. Contiene:

- `ARCamera`
- `ImageTarget`
- `Directional Light`
- `Punto_Aparicion1`
- `Punto_Aparicion2`
- `Punto_Aparicion3`
- `AdministradoAR`
- Modelos 3D de personajes con animación de sentado

Esta es la escena que debe abrirse para probar el proyecto.

### Escena de ejemplo: `Assets/SamplesResources/Scenes/0-Main.unity`

Es una escena de ejemplo de Vuforia. Está incluida en el proyecto, pero aparece deshabilitada en `EditorBuildSettings.asset`, por lo que no se usa como escena principal de la app.

### Escena de recuperación: `Assets/_Recovery/0.unity`

Parece ser una copia de recuperación de la escena principal. Puede servir como respaldo si `Silla.unity` se daña, pero no debe considerarse la escena principal salvo que sea necesario recuperar trabajo.

---

## Funcionamiento general

El flujo de ejecución del proyecto es el siguiente:

```text
1. Inicia la escena Silla.unity.
2. ARCamera solicita acceso a la cámara del dispositivo.
3. Vuforia inicializa el sistema de Realidad Aumentada.
4. La cámara busca el ImageTarget configurado.
5. Cuando Vuforia detecta la imagen:
   - Se ejecuta el evento OnTargetFound.
   - Se llama a SentarseAR_Grupo.OnMarkerFound().
6. El script coloca cada modelo en su punto de aparición.
7. Los modelos se vuelven visibles.
8. Se activa el trigger SentarTrigger en cada Animator.
9. Los personajes reproducen la animación de sentado.
```

### Relación entre objetos principales

```text
ARCamera
└── Usa Vuforia para activar la cámara y detectar targets.

ImageTarget
├── Representa la imagen/marcador que debe reconocer Vuforia.
├── Tiene puntos hijos de aparición:
│   ├── Punto_Aparicion1
│   ├── Punto_Aparicion2
│   └── Punto_Aparicion3
└── Al detectar el marcador llama a AdministradoAR.OnMarkerFound().

AdministradoAR
└── Tiene el script SentarseAR_Grupo con la lista de personajes.
```

---

## Scripts del proyecto

A continuación se explica cada script C# encontrado dentro del proyecto.

---

### `PedirCamers.cs`

> Ruta: `Assets/Scenes/PedirCamers.cs`  
> Clase principal: `PedirCamara`

Este script solicita permiso para usar la cámara en dispositivos Android.

```csharp
public class PedirCamara : MonoBehaviour
{
    void Start()
    {
#if UNITY_ANDROID
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
        }
#endif
    }
}
```

#### Qué hace

- Se ejecuta al iniciar la escena mediante el método `Start()`.
- Verifica si la app tiene permiso para usar la cámara.
- Si el permiso no ha sido concedido, solicita autorización al usuario.
- Solo se compila en Android gracias a la directiva `#if UNITY_ANDROID`.

#### Dónde se usa

En la escena `Silla.unity`, el script está asignado al objeto `ARCamera`.

#### Por qué es importante

Vuforia necesita acceder a la cámara para detectar el marcador. Sin este permiso, en Android la cámara puede no abrirse o la app puede fallar al intentar usar Realidad Aumentada.

---

### `SentarseAR_Directo.cs`

> Ruta: `Assets/Scenes/SentarseAR_Directo.cs`  
> Clase principal: `SentarseAR_Directo`

Este script está diseñado para manejar un solo modelo 3D. Permite ocultar el modelo al iniciar y mostrarlo cuando se detecta el marcador.

```csharp
public class SentarseAR_Directo : MonoBehaviour
{
    [Header("Referencias")]
    public Transform targetInicioAnimacion;

    private Animator animator;
    private bool animacionIniciada = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        SetModelVisibility(false);
    }

    public void OnMarkerFound()
    {
        if (!animacionIniciada)
        {
            transform.position = targetInicioAnimacion.position;
            transform.rotation = targetInicioAnimacion.rotation;

            SetModelVisibility(true);

            animator.SetTrigger("SentarTrigger");
            animacionIniciada = true;
        }
    }

    private void SetModelVisibility(bool isVisible)
    {
        Renderer[] renderers = GetComponentsInChildren<Renderer>();
        foreach (Renderer r in renderers)
        {
            r.enabled = isVisible;
        }
    }
}
```

#### Qué hace

- Guarda una referencia al componente `Animator` del objeto.
- Oculta todos los renderers del modelo al iniciar.
- Cuando se llama `OnMarkerFound()`:
  - Mueve el modelo a `targetInicioAnimacion`.
  - Copia la rotación de ese punto de inicio.
  - Muestra el modelo.
  - Activa el trigger `SentarTrigger`.
  - Bloquea la repetición de la animación con `animacionIniciada`.

#### Variables importantes

| Variable | Tipo | Función |
|---|---|---|
| `targetInicioAnimacion` | `Transform` | Punto donde aparecerá el modelo al detectar el marcador. |
| `animator` | `Animator` | Controla la animación del modelo. |
| `animacionIniciada` | `bool` | Evita que la animación se dispare más de una vez. |

#### Dónde se usa

No aparece conectado directamente en la escena principal revisada. Parece ser una versión alternativa o inicial del sistema, pensada para manejar un único personaje.

#### Uso esperado

Este script se puede colocar directamente en un personaje 3D. Después, en el evento `OnTargetFound` del `ImageTarget`, se puede llamar a `SentarseAR_Directo.OnMarkerFound()`.

---

### `SentarseAR_Grupo.cs`

> Ruta: `Assets/Scenes/SentarseAR_Grupo.cs`  
> Clases principales: `PersonaAR` y `SentarseAR_Grupo`

Este es el script principal de la escena `Silla.unity`. Maneja varios modelos 3D al mismo tiempo.

```csharp
[System.Serializable]
public class PersonaAR
{
    public GameObject modelo3D;
    public Transform puntoAparicion;
    [HideInInspector] public Animator animator;
}

public class SentarseAR_Grupo : MonoBehaviour
{
    [Header("Lista de Personajes")]
    public PersonaAR[] personas;

    private bool animacionIniciada = false;

    void Start()
    {
        foreach (PersonaAR p in personas)
        {
            if (p.modelo3D != null)
            {
                p.animator = p.modelo3D.GetComponent<Animator>();
                SetModelVisibility(p.modelo3D, false);
            }
        }
    }

    public void OnMarkerFound()
    {
        if (!animacionIniciada)
        {
            foreach (PersonaAR p in personas)
            {
                if (p.modelo3D != null && p.puntoAparicion != null)
                {
                    p.modelo3D.transform.position = p.puntoAparicion.position;
                    p.modelo3D.transform.rotation = p.puntoAparicion.rotation;

                    SetModelVisibility(p.modelo3D, true);

                    if (p.animator != null)
                    {
                        p.animator.SetTrigger("SentarTrigger");
                    }
                }
            }
            animacionIniciada = true;
        }
    }

    private void SetModelVisibility(GameObject modelo, bool isVisible)
    {
        Renderer[] renderers = modelo.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in renderers)
        {
            r.enabled = isVisible;
        }
    }
}
```

#### Qué hace la clase `PersonaAR`

`PersonaAR` es una clase serializable que sirve para organizar la información de cada personaje en el Inspector de Unity.

| Campo | Tipo | Función |
|---|---|---|
| `modelo3D` | `GameObject` | Referencia al personaje 3D. |
| `puntoAparicion` | `Transform` | Posición y rotación donde aparecerá el personaje. |
| `animator` | `Animator` | Se obtiene automáticamente en tiempo de ejecución. |

Gracias a `[System.Serializable]`, Unity permite editar el arreglo `personas` directamente desde el Inspector.

#### Qué hace `SentarseAR_Grupo`

- Recorre la lista de personajes al iniciar.
- Obtiene el `Animator` de cada modelo.
- Oculta todos los modelos al inicio para que no aparezcan antes de detectar el marcador.
- Cuando Vuforia detecta el `ImageTarget`, ejecuta `OnMarkerFound()`.
- En ese momento:
  - Coloca cada modelo en su punto de aparición.
  - Copia la rotación del punto correspondiente.
  - Hace visible cada modelo.
  - Dispara el trigger de animación `SentarTrigger`.
  - Evita que el proceso se repita varias veces.

#### Dónde se usa

En la escena principal `Silla.unity`, este script está asignado al objeto:

```text
AdministradoAR
```

El arreglo `personas` tiene configurados tres modelos:

| Modelo | Punto asignado |
|---|---|
| `Ch35_nonPBR@Sitting` | `Punto_Aparicion1` |
| `Vanguard By T. Choonyung@Sitting` | `Punto_Aparicion2` |
| `Meshy_AI_biped_Animation_Step_to_Sit_Transition_withSkin` | `Punto_Aparicion3` |

#### Evento conectado en Vuforia

En el objeto `ImageTarget`, el componente `DefaultObserverEventHandler` tiene configurado el evento:

```text
OnTargetFound -> AdministradoAR / SentarseAR_Grupo.OnMarkerFound()
```

Esto significa que cuando Vuforia encuentra el marcador, se activa la lógica del grupo de personajes.

---

### `AddVuforiaEnginePackage.cs`

> Ruta: `Assets/Editor/Migration/AddVuforiaEnginePackage.cs`  
> Clase principal: `AddVuforiaEnginePackage`

Este script no forma parte de la jugabilidad ni de la lógica AR visible para el usuario. Es un script de editor incluido por Vuforia Engine para ayudar a instalar, actualizar o mover paquetes de Vuforia dentro del proyecto.

#### Qué hace

- Se ejecuta automáticamente en el editor gracias al atributo `[InitializeOnLoad]`.
- Revisa el archivo `Packages/manifest.json`.
- Verifica si Vuforia Engine está instalado y si corresponde a la versión esperada.
- Puede mostrar diálogos en Unity para actualizar o instalar dependencias.
- Puede mover paquetes `.tgz` desde carpetas internas hacia `Packages/`.
- Puede actualizar las dependencias del manifiesto.
- Puede limpiar carpetas temporales de dependencias.

#### Funciones principales

| Función | Descripción |
|---|---|
| `ResolveDependenciesSilent()` | Resuelve dependencias sin mostrar diálogos. |
| `ResolveDependencies()` | Revisa dependencias y puede mostrar un diálogo al usuario. |
| `IsVuforiaUpToDate()` | Comprueba si Vuforia está instalado en una versión válida. |
| `DisplayAddPackageDialog()` | Muestra un diálogo para agregar o actualizar Vuforia. |
| `MovePackageFile()` | Mueve archivos `.tgz` del paquete. |
| `UpdateManifest()` | Modifica `Packages/manifest.json`. |
| `CleanupDependenciesFolder()` | Elimina carpetas temporales de dependencias. |
| `RestartEditor()` | Reinicia Unity si el proceso lo requiere. |

#### Importante

Este script pertenece a la infraestructura de Vuforia. Normalmente no se modifica a menos que se tenga claro cómo funciona el sistema de paquetes de Unity.

---

## Scripts externos relevantes de Vuforia

Además de los scripts propios del proyecto, la escena utiliza componentes importados por Vuforia:

| Componente | Objeto | Función |
|---|---|---|
| `VuforiaBehaviour` | `ARCamera` | Inicializa y administra el motor de Vuforia. |
| `DefaultInitializationErrorHandler` | `ARCamera` | Muestra o gestiona errores de inicialización de Vuforia. |
| `ImageTargetBehaviour` | `ImageTarget` | Define la imagen objetivo que Vuforia debe detectar. |
| `DefaultObserverEventHandler` | `ImageTarget` | Dispara eventos cuando el target se encuentra o se pierde. |
| `ImageTargetPreview` | `ImageTarget` | Muestra la previsualización del target en el editor. |

Estos componentes vienen del paquete de Vuforia y no se deben eliminar si se quiere conservar la funcionalidad AR.

---

## Animaciones y modelos 3D

El proyecto contiene varios modelos FBX, entre ellos:

```text
Assets/Scenes/Ch35_nonPBR@Sitting.fbx
Assets/Scenes/Vanguard By T. Choonyung@Sitting.fbx
Assets/Scenes/Meshy_AI_biped_Animation_Step_to_Sit_Transition_withSkin.fbx
Assets/Scenes/Warzombie F Pedroso@Sitting.fbx
Assets/Scenes/X Bot@Sitting.fbx
Assets/Scenes/Mosso.fbx
Assets/Scenes/Mosso_animado.fbx
```

La escena principal usa tres personajes dentro del script `SentarseAR_Grupo`:

- `Ch35_nonPBR@Sitting`
- `Vanguard By T. Choonyung@Sitting`
- `Meshy_AI_biped_Animation_Step_to_Sit_Transition_withSkin`

También existe un modelo `Warzombie F Pedroso@Sitting` en la escena, pero aparece desactivado y no está incluido en el arreglo `personas` del script principal.

### Controlador de animación

El controlador de animación principal es:

```text
Assets/Scenes/ControladorPersonaje.controller
```

Este controlador contiene:

- Estado `Reposo`, usado como estado inicial.
- Estado `Sentarse`.
- Trigger `SentarTrigger`.
- Transición de `Reposo` a `Sentarse` cuando se activa `SentarTrigger`.

El script `SentarseAR_Grupo` activa la animación con:

```csharp
p.animator.SetTrigger("SentarTrigger");
```

Por eso, si se cambia el nombre del trigger en el Animator, también debe actualizarse el nombre en el script.

---

## Requisitos para abrirlo

### Software recomendado

- Unity Hub.
- Unity `6000.3.9f1` o una versión compatible de Unity 6.
- Módulo Android Build Support si se quiere compilar en Android.
- Android SDK, NDK y OpenJDK instalados desde Unity Hub.
- Git LFS, si el proyecto se descarga desde GitHub.
- Un dispositivo Android con cámara para probarlo de forma real.

### Paquetes del proyecto

El archivo `Packages/manifest.json` incluye, entre otros:

```json
"com.ptc.vuforia.engine": "file:com.ptc.vuforia.engine-11.4.4.tgz",
"com.unity.ugui": "2.0.0",
"com.unity.test-framework": "1.6.0",
"com.unity.ide.visualstudio": "2.0.26",
"com.unity.ide.rider": "3.0.39"
```

## Cómo ejecutar el proyecto en Unity

### 1. Descargar correctamente el proyecto

Si se descarga desde GitHub, lo ideal es clonarlo usando Git LFS:

```bash
git lfs install
git clone <URL_DEL_REPOSITORIO>
cd Silla-con-AR-main
git lfs pull
```

Esto es importante porque muchos modelos, texturas, imágenes y paquetes están guardados con Git LFS.

### 2. Abrir el proyecto en Unity Hub

1. Abrir Unity Hub.
2. Seleccionar **Add / Add project from disk**.
3. Elegir la carpeta raíz del proyecto:

```text
Silla-con-AR-main/
```

4. Abrir el proyecto con Unity `6000.3.9f1` o una versión compatible.
5. Esperar a que Unity restaure los paquetes.

### 3. Verificar Vuforia

Al abrir Unity, revisar que Vuforia cargue correctamente.

Si Unity muestra errores relacionados con:

```text
com.ptc.vuforia.engine-11.4.4.tgz
```

probablemente el archivo local de Vuforia no se descargó bien por Git LFS. En ese caso se puede:

- Ejecutar `git lfs pull`.
- Descargar de nuevo el repositorio usando Git LFS.
- Instalar manualmente Vuforia Engine desde el sitio oficial de Vuforia.
- Corregir la referencia en `Packages/manifest.json`.

### 4. Abrir la escena principal

Abrir:

```text
Assets/Scenes/Silla.unity
```

Esta escena es la que está habilitada en Build Settings.

### 5. Revisar los objetos principales

En la jerarquía se deben encontrar:

```text
ARCamera
ImageTarget
Directional Light
AdministradoAR
Punto_Aparicion1
Punto_Aparicion2
Punto_Aparicion3
```

### 6. Ejecutar en el editor

Presionar **Play** en Unity.

Para probar el reconocimiento se necesita mostrar a la cámara la imagen objetivo configurada en el `ImageTarget`. En este proyecto aparece como:

```text
Assets/Scenes/images.jpg
```

Si el archivo se descargó correctamente, puede imprimirse o mostrarse en otra pantalla para que la cámara lo detecte.

---

## Cómo compilar para Android

El proyecto está configurado para Android con los siguientes datos encontrados en `ProjectSettings.asset`:

| Configuración | Valor |
|---|---|
| Nombre del producto | `silla` |
| Identificador Android | `com.silla3` |
| Versión del bundle | `11.4.4` |
| Minimum SDK | API 29 |
| Target SDK | Automático / valor por defecto de Unity |
| Arquitectura principal | ARM64 |
| Uso de cámara | `Camera access required for target detection and tracking` |

### Pasos para compilar

1. Abrir el proyecto en Unity.
2. Ir a:

```text
File > Build Profiles
```

   o, en versiones anteriores:

```text
File > Build Settings
```

3. Seleccionar **Android**.
4. Presionar **Switch Platform**.
5. Confirmar que la escena `Assets/Scenes/Silla.unity` esté incluida y habilitada.
6. Conectar un dispositivo Android con depuración USB activada.
7. Presionar **Build And Run**.
8. Al abrir la app en el teléfono, aceptar el permiso de cámara.
9. Apuntar la cámara al marcador configurado.

---

## Configuración importante de Vuforia

### ARCamera

El objeto `ARCamera` contiene componentes de Vuforia y el script `PedirCamara`.

Su función es:

- Activar la cámara.
- Inicializar Vuforia.
- Servir como cámara principal de la experiencia AR.

### ImageTarget

El objeto `ImageTarget` representa la imagen que Vuforia debe reconocer.

Configuración encontrada:

```text
Target name: images
Width: 0.2
Height: 0.2
Runtime texture: Assets/Scenes/images.jpg
```

El componente `DefaultObserverEventHandler` tiene configurado el evento `OnTargetFound`, el cual llama al método:

```text
SentarseAR_Grupo.OnMarkerFound()
```

### Licencia de Vuforia

El proyecto contiene una configuración de licencia en `Assets/Resources/VuforiaConfiguration.asset`.

Recomendación importante:

- No publicar claves de Vuforia en repositorios públicos.
- Si se va a entregar o publicar el proyecto, se recomienda generar una nueva licencia desde la cuenta propia de Vuforia y reemplazarla en la configuración del proyecto.

---

## Problemas comunes y soluciones

### 1. Unity no encuentra modelos, texturas o imágenes

**Causa probable:** los archivos pesados están como punteros de Git LFS y no como archivos reales.

**Solución:** ejecutar:

```bash
git lfs install
git lfs pull
```

Si se descargó como ZIP desde GitHub, es posible que el ZIP no incluya los archivos reales de LFS. En ese caso conviene clonar el repositorio con Git.

---

### 2. Vuforia no se instala o aparece error con `.tgz`

**Causa probable:** el archivo `Packages/com.ptc.vuforia.engine-11.4.4.tgz` también está administrado por Git LFS.

**Solución:** descargar correctamente los archivos LFS o reinstalar Vuforia Engine manualmente.

---

### 3. La cámara no se abre en Android

**Posibles causas:**

- No se aceptó el permiso de cámara.
- El dispositivo bloqueó permisos.
- Vuforia no inicializó correctamente.
- El proyecto no tiene permiso de cámara en Android.

**Solución:**

- Revisar permisos de la app en Android.
- Desinstalar y volver a instalar la app.
- Revisar que `PedirCamara` esté en `ARCamera`.
- Revisar la configuración de Vuforia.

---

### 4. No aparece ningún modelo al detectar el marcador

**Posibles causas:**

- El marcador no se está detectando.
- El evento `OnTargetFound` no está conectado.
- Los modelos no están asignados en `AdministradoAR`.
- El Animator no tiene el trigger `SentarTrigger`.
- Los modelos o texturas no se descargaron por Git LFS.

**Solución:**

- Revisar el componente `DefaultObserverEventHandler` en `ImageTarget`.
- Confirmar que `OnTargetFound` llame a `AdministradoAR -> SentarseAR_Grupo.OnMarkerFound()`.
- Revisar el arreglo `personas` en `AdministradoAR`.
- Confirmar que cada personaje tenga un `Animator`.
- Confirmar que `ControladorPersonaje.controller` tenga el trigger `SentarTrigger`.

---

### 5. La animación no se reproduce

**Posibles causas:**

- El modelo no tiene `Animator`.
- El modelo no tiene asignado `ControladorPersonaje.controller`.
- El trigger del Animator cambió de nombre.
- El clip de animación no es compatible con el rig del modelo.

**Solución:**

- Revisar el componente `Animator` del modelo.
- Confirmar que el trigger se llame exactamente:

```text
SentarTrigger
```

- Revisar que el estado `Sentarse` tenga una animación asignada.

---

### 6. Unity muestra scripts faltantes o errores de renderizado

En la escena aparece una referencia a `UniversalAdditionalLightData`, pero en el `manifest.json` no se encontró explícitamente el paquete de Universal Render Pipeline.

Si Unity muestra errores por scripts faltantes relacionados con URP, se puede:

- Instalar Universal RP desde Package Manager.
- Eliminar el componente faltante si solo afecta a la luz y no es necesario.
- Revisar si el proyecto originalmente fue creado con una plantilla URP.

---

## Notas sobre Git LFS

El proyecto utiliza Git LFS para muchos archivos pesados. En el ZIP analizado varios archivos aparecen como punteros de texto, no como archivos binarios reales.

Ejemplo de archivo puntero:

```text
version https://git-lfs.github.com/spec/v1
oid sha256:...
size ...
```

Esto significa que el archivo real no está presente en el ZIP analizado. Archivos afectados incluyen:

- Modelos `.fbx`.
- Texturas `.png`.
- Imágenes `.jpg`.
- Archivos de Vuforia `.tgz`.
- Recursos de ejemplo.

Para trabajar correctamente con el proyecto, se recomienda usar:

```bash
git lfs install
git clone <URL_DEL_REPOSITORIO>
cd Silla-con-AR-main
git lfs pull
```

Sin los archivos reales de LFS, Unity puede abrir la estructura del proyecto, pero no podrá importar correctamente modelos, texturas, marcador ni el paquete local de Vuforia.

---

## Licencia

El proyecto incluye una licencia MIT:

```text
MIT License
Copyright (c) 2026 Alfredo Yael Díaz Peña
```

La licencia MIT permite usar, copiar, modificar, fusionar, publicar, distribuir y sublicenciar el software, siempre que se mantenga el aviso de copyright y la licencia en las copias o partes sustanciales del proyecto.

---

## Resumen técnico corto

Este proyecto es una app AR hecha en Unity con Vuforia. Detecta una imagen objetivo llamada `images`, y al reconocerla ejecuta un evento que activa el script `SentarseAR_Grupo`. Ese script muestra tres personajes 3D, los posiciona en puntos definidos como hijos del `ImageTarget` y dispara una animación de sentado mediante el trigger `SentarTrigger`. La app está orientada a Android y requiere cámara, Vuforia correctamente instalado y los archivos reales descargados con Git LFS.
#Video de funcionamiento
https://drive.google.com/file/d/1d4l8v5Vg6cLj1dGBuu0PyLdSsW1pubz8/view?usp=sharing
