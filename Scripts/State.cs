using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachineSystem
{
	[System.Serializable]
	public abstract class State<T>
	{
		protected T Owner;
		private GameStateBase owner;

		public State(T owner)
		{
			Owner = owner;
		}

		protected State(GameStateBase owner)
		{
			this.owner = owner;
		}

		public virtual void StateUpdate(T owner) { }
		public virtual void StateEnter(T owner) { }
		public virtual void StateExit(T owner) { }
		public virtual IEnumerator StateUpdateEn(T owner) { yield break; }
		public virtual void StateFixeUpdate(T owner) { }
	}

	public class GameStateBase{}

}
