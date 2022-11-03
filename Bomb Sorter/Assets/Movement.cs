using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private Vector2 target;
    private float speed = 900 ;
    private float x;
    private float y; 

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("target").GetComponent<RectTransform>().anchoredPosition; 
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.S)) {

        if (Mathf.Approximately(target.x, GetComponent<RectTransform>().anchoredPosition.x) &&
            Mathf.Approximately(target.y, GetComponent<RectTransform>().anchoredPosition.y))
        {
            x = Random.Range(-640, 640);
            y = Random.Range(-270, 270);
           target = new Vector2(x, y);
            print(target);
        }

        Vector2 s = GetComponent<RectTransform>().anchoredPosition;

        /*
        var distance = Vector2.Distance(s, target);
        Vector2 direction = s - target;

        direction.Normalize();
        */

        // makes the square face its target position. 
        float angle = Mathf.Atan2(s.y, s.x) * Mathf.Rad2Deg;

        // moves the object to its target position. ]

        GetComponent<RectTransform>().anchoredPosition = Vector2.MoveTowards(GetComponent<RectTransform>().anchoredPosition, target, speed * Time.deltaTime);

        // turns the object to face its target position. 
        //GetComponent<RectTransform>().rotation = Quaternion.Euler(Vector3.forward * angle);

        //}
    }
}
