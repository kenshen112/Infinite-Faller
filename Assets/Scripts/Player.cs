using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class Player : MonoBehaviour
{
    float depthScore;
    Rigidbody2D rb;
    BoxCollider2D box;
    Camera cam;

    [SerializeField]
    GameObject ScoreCounter;

    [SerializeField]
    LayerMask Mask;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
        cam = GetComponent<Camera>();
        depthScore = 0.00f;
        ScoreCounter.GetComponent<TextMeshPro>().text = "Score: " + depthScore.ToString();
    }

    bool isTag(string tag)
    {
        // Box project
        RaycastHit2D hit = Physics2D.BoxCast(box.bounds.center, box.bounds.size, 0f, Vector2.down, 1f, Mask);
        return hit.collider.CompareTag(tag);
    }

    // Update is called once per frame
    void Update()
    {
        if (isTag("Enemy"))
        {
            depthScore += 1;
            ScoreCounter.GetComponent<TextMeshPro>().text = "Score: " + depthScore.ToString();
        }
        else
        {
            Debug.Log("DEAD");
            GetComponent<Rigidbody2D>().gravityScale = 0;
            Destroy(gameObject);
        }
    }
}
