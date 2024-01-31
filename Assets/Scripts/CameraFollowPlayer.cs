using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public GameObject target;
    public float smoothing = 5f;
    [SerializeField] Vector3 offset;
    public DialogueControl _dialogueControl;
    
    void Start()
    {
 
    }

    void LateUpdate()
    {
        
        transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, smoothing * Time.deltaTime);
        
    }
}
