using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Animations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        DOTween.Sequence();
        DOTween.Kill(gameObject.transform);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
