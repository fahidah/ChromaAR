using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeControl : MonoBehaviour
{
    [Tooltip("Starting position - target pivot")]
    private Transform targetPosition;

    [Tooltip("Threshold time for fast swipe in seconds")]
    public float fastSwipeThresholdTime = 0.3f;

    [Tooltip("Threshold time for fast swipe in (unscaled) pixels")]
    public int fastSwipeThresholdDistance = 100;

    [Tooltip("How fast will page lerp to target position")]
    public float decelerationRate = 10f;

    // fast swipes should be fast and short. If too long, then it is not fast swipe
    private int _fastSwipeThresholdMaxLimit;


    //animals in container
    private int _animalCount;
    private int _currentAnimal;



    // Start is called before the first frame update
    void Start()
    {
        targetPosition = gameObject.transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SnapToTarget()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition.position, Time.deltaTime);
    }


}
