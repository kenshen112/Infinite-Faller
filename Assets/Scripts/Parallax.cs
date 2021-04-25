using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    Camera cam;
    Transform camTransform;
    Vector2 lastPos;
    Vector3 delta;
    [SerializeField]
    float distanceY;
    [SerializeField]
    float smoothing;
    [SerializeField]
    List<Transform> backgrounds;
    List<float> parallaxScales;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        camTransform = cam.transform;
        parallaxScales = new List<float>();
        for (int i = 0; i < backgrounds.Count; i++)
        {
            parallaxScales[i] = backgrounds[i].position.z * -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < backgrounds.Count; i++)
        {
            float parallax = (lastPos.y - cam.transform.position.y) * parallaxScales[i];
            float backgroundTargetY = backgrounds[i].position.y + parallax;
            Vector3 backgroundPos = new Vector3(backgrounds[i].position.x, backgroundTargetY, backgrounds[i].position.z);
            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundPos, smoothing * Time.deltaTime);
        }
        lastPos = camTransform.position;

    }
}
