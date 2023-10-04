using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] float speed;
    void LateUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            float mouseX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            float mouseZ = Camera.main.ScreenToWorldPoint(Input.mousePosition).z;
            float fixedXpos = Mathf.Clamp(mouseX,-19.5f, 9f);
            float fixedZpos = Mathf.Clamp(mouseZ,-20,10);
            transform.position = Vector3.Lerp(transform.position ,new Vector3(fixedXpos, transform.position.y, fixedZpos),10);
        }      
    }
}
