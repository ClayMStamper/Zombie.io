using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Animator))]
public class CharacterAnimation : MonoBehaviour {

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void SetBlendValue(float blend){
        anim.SetFloat("Blend", blend);
    }

    public void AddBlendValue(float increment){

        float blend = anim.GetFloat("Blend");
        blend += increment;
        anim.SetFloat("Blend", blend);

    }

    public void SubtractBlendValue(float decrement){

        float blend = anim.GetFloat("Blend");
        blend -= decrement;
        anim.SetFloat("Blend", blend);

    }
}
