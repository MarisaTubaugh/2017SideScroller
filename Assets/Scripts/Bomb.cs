using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : Throwable

{
	public float blastRadius = 5;

		void OncollisionEnter2D(Collision2D coll)

		{
			var player = coll.gameObject.GetComponent<Player>();
			if (isActive && player == null)
			{
				Explode();
			}
		}

			

	public override void Attack()
		{

			collider2D.enabled = true;
			rigidbody2D.isKinematic = false;
			rigidbody2D.velocity = new Vector2(5, 0);
			transform.parent = null;

		}

		public override void GetPickedUp(Player player)
		{
			if (isActive)
			{
				return;
			}

			base.GetPickedUp(player);

		}


		public void Explode()
		{
			var enemies = FindObjectsOfType<Enemy>();

			foreach (var e in enemies)
			{
				if (Vector3.Distance(this.transform.position, e.transform.position) < blastRadius)
				{
					e.gameObject.SetActive(false);
				}
			}
			// Set myself (aka the bomb) to NOT.Active. That way the bomb disappears, and can not be picked up again.
			gameObject.SetActive(false);
		}
}	