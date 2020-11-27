using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{

    public float speed = 0;
    public float speedAccelerationPerSecond = 0.1f;
    

    public Color color;
    public TextMesh text;
    float t;
    Vector3 startPosition;
    Vector3 target;
    float timeToReachTarget;
    void Start()
    {
        text = GetComponent<TextMesh>();
        text.color = color;
        startPosition = transform.position;
        target = new Vector3(transform.position.x, transform.position.y, -30f);
        SetDestination(target, 4f);
    }
    void Update()
    {
        speed += speedAccelerationPerSecond * Time.deltaTime;
        text.color = color;
        color.a = speed;
        t += Time.deltaTime / timeToReachTarget;
        transform.position = Vector3.Lerp(startPosition, target, t);
    }
    public void SetDestination(Vector3 destination, float time)
    {
        t = 0;
        startPosition = transform.position;
        timeToReachTarget = time;
        target = destination;
    }
}
