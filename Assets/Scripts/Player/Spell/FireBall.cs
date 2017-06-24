﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRuby.PyroParticles;

public class FireBall : Spell {

	public GameObject ball;

	void Start () {
		base.Start ();
	}
	
	void Update () {
		base.Update ();
	}

	public override void use()
	{
		Vector3 pos = RPGPlayer.Player.transform.position;
		pos.y += 4;
		GameObject fire = GameObject.Instantiate(ball, pos, Quaternion.LookRotation( Constants.GetMousePosition()));
	}

	public override string getUpgrade()
	{return null;}
}
