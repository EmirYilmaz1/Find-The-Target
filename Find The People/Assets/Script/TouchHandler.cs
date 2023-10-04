using System;
using UnityEngine;

public class TouchHandler : MonoBehaviour 
{
    public event Action OnTargetFound;
    [SerializeField] ParticleSystem particleSystem;
    private RaycastHit raycastHit;
    
    private void Update() 
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit[] raycastHits = Physics.RaycastAll(ray);
            foreach(RaycastHit raycastHit in  raycastHits)
            {
                if(raycastHit.collider.TryGetComponent<Person>(out Person person))
                {
                    if(person.isTarget == true)
                    {
                        Instantiate(particleSystem, raycastHit.point, Quaternion.identity);
                        FindObjectOfType<CameraMovement>().enabled = false;
                        Invoke(nameof(CallFoundAction), 1f);
                        break;
                    }
                }
            }
        }    
    }

    private void CallFoundAction()
    {
        OnTargetFound?.Invoke();
    }
}