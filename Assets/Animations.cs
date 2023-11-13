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

        transform.DOMove(new Vector3(2, 2, 2), 1);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
