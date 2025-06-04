using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class cubeRotation : MonoBehaviour
{
    int currentFace;
    internal float rotation;
    [SerializeField]
    Transform cubeTransform;  
    [SerializeField]
    float speed,rotationSpeed = 1f;
    [SerializeField]
    float jumpPower = 2f;
    [SerializeField]
    int jumpCount = 1;
    float zPosition;
    void Start()
    {


        //Quaternion targetRotation = Quaternion.Euler(0, 90, 0);
        //StartRotation(targetRotation);
        zPosition = cubeTransform.position.z;
    }

    internal void StartRotation(Vector3 rotate)
    {
       
        cubeTransform.DOLocalRotate(rotate, rotationSpeed);
        cubeTransform.DOMoveZ(
            cubeTransform.position.z - 5f,speed).SetEase(Ease.OutQuad).OnComplete(() => {cubeTransform.DOMoveZ(zPosition,speed).SetEase(Ease.InQuad);});
    }
}
