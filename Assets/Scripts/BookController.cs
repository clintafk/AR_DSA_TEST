using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject bookPrefab;
    public Transform baseBookPosition;
    private int stackCount = 1;
    private float bookHeight = 0.2f;

    public void addBook() 
    {
        Vector3 newPosition = baseBookPosition.position + Vector3.up * bookHeight * stackCount;     
        Instantiate(bookPrefab, newPosition, Quaternion.identity);
        stackCount++;
    }
}
