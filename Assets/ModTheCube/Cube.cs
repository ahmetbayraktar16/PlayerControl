using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float xAngle = 360f;
    public Vector3 newPos = new Vector3(3,6,0);
    public float newScale = 2f;

    void Start()
    {
        transform.position = newPos;
        transform.localScale = Vector3.one * newScale;
    }

    void Update()
    {
        Material material = Renderer.material;

        material.color = Random.ColorHSV();
        transform.Rotate(xAngle * Time.deltaTime, 0.0f, 0.0f);
    }
}
