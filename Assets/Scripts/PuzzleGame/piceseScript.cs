using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class piceseScript : MonoBehaviour
{
    private Vector3 rightPosition;
    public bool InRightPosition;
    public bool Selected;
    void Start()
    {
        // bellirli bi alanda puzzle parçalarını rastgele yerleştir
        rightPosition = transform.position;
        transform.position = new Vector3(Random.Range(1, 9),Random.Range(3,-4));
    }
    
    void Update()
    {
        if (Vector3.Distance(transform.position,rightPosition)<2.5f)
        {
            if (!Selected)
            {
                if (InRightPosition==false)
                {
                    transform.position = rightPosition;
                    InRightPosition = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                }
            }
        }
    }
}
