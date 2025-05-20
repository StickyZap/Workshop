using UnityEngine;

public class Player : MonoBehaviour
{
    private LayerMask mask;
    void Start()
    {
        mask = LayerMask.GetMask("Interactable");
    }
    void Update()
    {
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * 7f, Color.green);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.transform.position,
                                Camera.main.transform.forward,
                                out RaycastHit hit,
                                7f, mask))
            {
                Debug.Log("Hit something");
                IInteractable comp = hit.collider.gameObject.GetComponent<IInteractable>();
                comp.Interact();
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            GameManager.instance.OpenInventoryCanvas();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            GameManager.instance.CloseInventoryCanvas();
        }


    }
}
