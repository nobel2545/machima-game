using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStateMachine : MonoBehaviour
{
    public BaseCharacter Character;

    public enum TurnState {
        PROCESSING,
        SELECTING,
        WALK,
        ACTION,
        DEAD
    }

    public TurnState currentState;

    private float cur_cooldown = 0f;
    private float max_cooldown = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState) {

            case (TurnState.PROCESSING):
            break;

            case (TurnState.SELECTING):
            break;

            case (TurnState.WALK):
            break;

            case (TurnState.ACTION):
            break;

            case (TurnState.DEAD):
            break;

        }
    }

    void UpgradeHealthBar() {
        cur_cooldown = cur_cooldown + Time.deltaTime;
    }
}
