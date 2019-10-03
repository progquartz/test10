using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public Rigidbody2D rb;
    UiManager ui;
    public Sprite test;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        ui = gameObject.GetComponent<UiManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        Instantiate(test, transform.position, transform.rotation);
    }
}
