using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Botsing : MonoBehaviour
{
    // Reference naar je TMP tekst op het Canvas
    public TMP_Text collisionText;

    private void Start()
    {
        //collisionText.text = "TEST";
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Controller"))
            return;
        string thisObject = gameObject.name;
        string parentObject = transform.parent != null ? transform.parent.name : "Geen parent";
        string otherObject = collision.gameObject.name;

        string message =
            thisObject + " zegt: Ik ben geraakt door " +
            otherObject;

        // Schrijf naar TMP tekst 
        if (collisionText != null)
        {
            collisionText.text = message;
        }
    }
}