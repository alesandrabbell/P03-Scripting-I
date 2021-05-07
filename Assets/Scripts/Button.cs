using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] AudioClip _hoverSound;
   
    

    private void OnMouseEnter()
    {
        //Debug.Log("Choice Button.");
        AudioHelper.PlayClip2D(_hoverSound, 7);
    }






}
