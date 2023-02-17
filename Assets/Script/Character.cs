using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int LifeMax = 100;
    public Sprite SpritePortrait;
    public SpriteRenderer Visual;
    public int Life = 100;
    public Animator Animator;

    public void Attack(Character defender)
    {
        Animator.SetTrigger("attack");
        defender.Hit();
    }


    internal void Hit()
    {
        Animator.SetTrigger("hit");
    }
}