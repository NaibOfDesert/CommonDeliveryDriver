using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryController : MonoBehaviour{
    [SerializeField] string packageTag;
    [SerializeField] string deliveryTag;
    [SerializeField] Color32 hasPackageColor;
    [SerializeField] Color32 hasNotPackageColor;
    [SerializeField] float destroyDelay;
    [SerializeField] bool hasPackage;

    SpriteRenderer spriteRenderer; 

    void Start(){
        hasPackageColor = new Color (0.45f , 0.95f, 0.75f, 1);
        hasNotPackageColor = new Color (0.95f, 0.45f, 0.65f, 1);
        destroyDelay = 0.5f;
        hasPackage = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collider){
        Debug.Log("Collision");
    }

    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.tag == packageTag && !hasPackage){
            Debug.Log("It's package!!"); 
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(collider.gameObject, destroyDelay);
        }

        if(collider.tag == deliveryTag && hasPackage){
            Debug.Log("It's customer!!"); 
            hasPackage = false;
            spriteRenderer.color = hasNotPackageColor;
        }
    }

    private void OnTriggerExit2D(Collider2D collider){
         
    }
}
