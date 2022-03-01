using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    void Start() {
    }


    public int Turn { get; set; }
    public Player player { get; set; }


    public GameState(Player player){
        this.player = player;
        this.Turn = 0;
    }

    public static GameState InitializeGameState(Player player){
        return new GameState(player);
    }

    public void EndTurn(){
        this.Turn += 1;
        this.player.CollectIncome();
    }

    public void AdjustPopulationOnTurnEnd(){
        foreach (Village village in this.player.villages)
        {
            float randomNum = (((float) Random.Range(90, 110))/100);
            while (randomNum == 1F)
            {
                randomNum = (((float) Random.Range(90, 110))/100);
            }
            float population = village.Population;
            population *= randomNum;
            village.Population = (int) population;
        }
    }
}