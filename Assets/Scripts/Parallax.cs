using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Camera cam;
    Transform camTransform;
    Vector2 lastPos;
    [SerializeField]
    float movementSpeed;
    [SerializeField]
    float parallax;

    [SerializeField]
    float sizeImage;
    float startPos;

    // Start is called before the first frame update
    void Start()
    {
        camTransform = cam.transform;
        startPos = transform.position.y;
    }

    void Move()
    {
        Vector2 movementDelta = new Vector2(0, (movementSpeed));
        transform.position += (Vector3)(movementDelta * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        // Need to add a constant Y to background
        Move();
            
        float pTemp = (lastPos.y - cam.transform.position.y) * (1 - parallax);
        float distance = (cam.transform.position.y * parallax);
        transform.position = new Vector3(transform.position.x, startPos + distance, transform.position.z);
        lastPos = camTransform.position;
        if (pTemp > startPos + sizeImage)
        {
            startPos += sizeImage;
        }
        else if (pTemp < startPos - sizeImage)
        {
            startPos -= sizeImage;
        }
    }
}
