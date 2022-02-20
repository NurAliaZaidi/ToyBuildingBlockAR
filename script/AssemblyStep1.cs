using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssemblyStep1 : MonoBehaviour
{

    private Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.speed = 0f;
    }

    public void AnimAssembly1()
    {
        Anim.Play("animStep1Assemble", -1, 0f);
        Anim.speed = 1f;
    }

    public void AnimAssembly2()
    {
        Anim.Play("animStep2Assemble", -1, 0f);
        Anim.speed = 1f;
    }

    public void AnimAssembly3()
    {
        Anim.Play("animStep3Assemble", -1, 0f);
        Anim.speed = 1f;
    }

    public void AnimAssembly4()
    {
        Anim.Play("animStep4Assemble", -1, 0f);
        Anim.speed = 1f;
    }

    public void AnimAssembly5()
    {
        Anim.Play("animStep5Assemble", -1, 0f);
        Anim.speed = 1f;
    }

    public void AnimAssembly6()
    {
        Anim.Play("animStep6Assemble", -1, 0f);
        Anim.speed = 1f;
    }
}
