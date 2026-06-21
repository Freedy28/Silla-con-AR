using UnityEngine;

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