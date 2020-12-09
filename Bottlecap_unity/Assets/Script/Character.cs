﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected float hp;
    protected float dmg;
    protected float speed;
    [SerializeField] protected Sprite image;
    //range is times 100 px
    protected float range;

    public float getHP(){return hp;}
    public void setHP(float num){hp += num;}
    public float getDMG(){return dmg;}
    public void setDMG(float num){dmg += num;}
    public float getSPEED(){return speed;}
    public void setSPEED(float num){speed += num;}
    /* change the character model... not done
    public void setIMAGE(){return null;}*/
    public float getRANGE(){return range;}
    public void setRANGE(float num){range += num;;}

}