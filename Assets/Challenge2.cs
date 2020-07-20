using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
	private int hp = 100;
	private int power = 25;
	private int mp = 53;

	public void Attack()
	{
		Debug.Log(this.power + "のダメージを与えた！");
	}

	public void Defence(int damage)
	{
		Debug.Log(damage + "のダメージを受けた！");
		this.hp -= damage;
	}

	public void Magic()
	{

		if (this.mp >= 5)
		{
			this.mp -= 5;
			Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
		}
		else 
		{
			Debug.Log("MPが足りないため魔法が使えない。");
		}
	}
}

public class Challenge2 : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Boss lastboss = new Boss();
		lastboss.Attack();
		lastboss.Defence(3);

		for (int i=0; i<10; i++) //Magic関数を10回呼び出し
		{
			lastboss.Magic();
		}

		lastboss.Magic(); //更に呼び出し

	} //Start End
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
