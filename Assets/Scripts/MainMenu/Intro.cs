using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    [SerializeField] private Animator backGroundAnimation;
    [SerializeField] private Animator squirrelAnimation;

    void Awake()
    {
        backGroundAnimation = GetComponent<Animator>();
        squirrelAnimation = GetComponent<Animator>();
    }

    void Start()
    {
        if (backGroundAnimation != null)
        {
            backGroundAnimation.Play("FadeInIntro");
        }
    }
}
