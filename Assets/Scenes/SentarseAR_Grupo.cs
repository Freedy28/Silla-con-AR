using UnityEngine;

// Esta clase agrupa el modelo y su punto de aparición para mantener orden en el Inspector
[System.Serializable]
public class PersonaAR
{
    public GameObject modelo3D;
    public Transform puntoAparicion;
    [HideInInspector] public Animator animator; // Se oculta porque el script lo buscará solo
}

public class SentarseAR_Grupo : MonoBehaviour
{
    [Header("Lista de Personajes")]
    public PersonaAR[] personas; // Arreglo que contendrá a tus 3 modelos

    private bool animacionIniciada = false;

    void Start()
    {
        // Al iniciar, recorremos la lista para ocultar a todos y guardar sus Animators
        foreach (PersonaAR p in personas)
        {
            if (p.modelo3D != null)
            {
                p.animator = p.modelo3D.GetComponent<Animator>();
                SetModelVisibility(p.modelo3D, false);
            }
        }
    }

    // Este método se conectará a Vuforia
    public void OnMarkerFound()
    {
        if (!animacionIniciada)
        {
            // Recorremos la lista para posicionar y animar a cada uno
            foreach (PersonaAR p in personas)
            {
                if (p.modelo3D != null && p.puntoAparicion != null)
                {
                    // 1. Posicionar
                    p.modelo3D.transform.position = p.puntoAparicion.position;
                    p.modelo3D.transform.rotation = p.puntoAparicion.rotation;

                    // 2. Hacer visible
                    SetModelVisibility(p.modelo3D, true);

                    // 3. Disparar animación
                    if (p.animator != null)
                    {
                        p.animator.SetTrigger("SentarTrigger");
                    }
                }
            }
            animacionIniciada = true;
        }
    }

    // Función auxiliar para ocultar/mostrar un modelo específico
    private void SetModelVisibility(GameObject modelo, bool isVisible)
    {
        Renderer[] renderers = modelo.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in renderers)
        {
            r.enabled = isVisible;
        }
    }
}