using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;
	public float backwardsspeed;
	public float rotationspeed;
	public Animator anim;
	int attack01;
	int attack02;
	int attack03;
	int battleWalkBackward;
	int battleWalkForward;
	int battleWalkLeft;
	int battleWalkRight;
	int defend;
	int die;
	int getHit;
	int idle02;
	int jump;
	int walk;
	int taunt;
	int run;


	void Awake () 
	{

	}

	void start()
	{
		speed = 0f;
		backwardsspeed = 0f;
		rotationspeed = 0f;
		anim = GetComponent<Animator>();
		attack01 = Animator.StringToHash("attack_01");
		attack02 = Animator.StringToHash("attack_02");
		attack03 = Animator.StringToHash("attack_03");
		battleWalkBackward = Animator.StringToHash("walkBattleBackward");
		battleWalkForward = Animator.StringToHash("walkBattleForward");
		battleWalkLeft = Animator.StringToHash("walkBattleLeft");
		battleWalkRight = Animator.StringToHash("walkBattleRight");
		defend = Animator.StringToHash("defend");
		die = Animator.StringToHash("die");
		getHit = Animator.StringToHash("getHit");
		idle02 = Animator.StringToHash("idle_02");
		jump = Animator.StringToHash("jump");
		walk = Animator.StringToHash("walk");
		taunt = Animator.StringToHash("taunt");
		run = Animator.StringToHash("run");
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.W)) 
		{
			anim.SetBool ("idle", false);
			Walk();
			transform.Translate (0, 0, speed * Time.deltaTime);
		}
		if (Input.GetKeyUp(KeyCode.W)) 
		{
			anim.SetBool ("walk", false);
			idle ();
		}
		if (Input.GetKey(KeyCode.S)) 
		{
			anim.SetBool ("idle", false);
			BattleWalkBackward();
			transform.Translate (0, 0, -backwardsspeed * Time.deltaTime);
		}
		if (Input.GetKeyUp(KeyCode.S)) 
		{
			anim.SetBool ("battleBack", false);
			idle ();
		}
		if (Input.GetKey(KeyCode.Q)) 
		{
			anim.SetBool ("idle", false);
			BattleWalkLeft();
			transform.Translate (-backwardsspeed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKeyUp(KeyCode.Q)) 
		{
			anim.SetBool ("battleLeft", false);
			idle ();
		}
		if (Input.GetKey(KeyCode.E)) 
		{
			anim.SetBool ("idle", false);
			BattleWalkRight();
			transform.Translate (backwardsspeed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKeyUp(KeyCode.E)) 
		{
			anim.SetBool ("battleRight", false);
			idle ();
		}
		if (Input.GetKey(KeyCode.D)) 
		{
			transform.Rotate(Vector3.up * Time.deltaTime * rotationspeed, Space.World);
		}
		if (Input.GetKey(KeyCode.A)) 
		{
			transform.Rotate(-Vector3.up * Time.deltaTime * rotationspeed, Space.World);
		}


	}

	public void Attack01 ()
	{
		anim.SetBool("attack01",true);
	}

	public void Attack02 ()
	{
		anim.SetBool("attack02",true);
	}

	public void Attack03 ()
	{
		anim.SetBool("attack03",true);
	}

	public void BattleWalkBackward ()
	{
		anim.SetBool("battleBack",true);
	}

	public void BattleWalkForward ()
	{
		anim.SetBool("battleForward",true);
	}

	public void BattleWalkLeft ()
	{
		anim.SetBool("battleLeft",true);
	}

	public void BattleWalkRight ()
	{
		anim.SetBool("battleRight",true);
	}

	public void Defend ()
	{
		anim.SetBool("defend",true);
	}

	public void Die ()
	{
		anim.SetBool("die",true);
	}

	public void GetHit ()
	{
		anim.SetBool("getHit",true);
	}

	public void Idle02 ()
	{
		anim.SetBool("idle_02",true);
	}

	public void Jump ()
	{
		anim.SetBool("jump",true);
	}

	public void Walk ()
	{
		anim.SetBool("walk",true);
	}

	public void Taunt ()
	{
		anim.SetBool("taunt",true);
	}

	public void Run ()
	{
		anim.SetBool("run",true);
	}
	public void idle ()
	{
		anim.SetBool("idle",true);
	}

}