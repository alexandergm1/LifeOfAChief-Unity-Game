using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{

    public static string playerNameStr;
    public Text Name;
    public Text Lumber;
    public Text Gold;
    public static Player player;
    public static GameState gameState;
    public static Map map;

    void Start(){
        map = Map.InitializeMap();
        player = Player.InitializePlayer(playerNameStr);
        player.TakeControlOfVillageFromMap(map, "Village1");
        player.TakeControlOfVillageFromMap(map, "Village2");
        player.TakeControlOfVillageFromMap(map, "Village3");
        player.TakeControlOfCastleFromMap(map, "Dunvegan");
        gameState = GameState.InitializeGameState(player);
        ClickBuilding.player = player;
    }

    public void MainEndTurn(){
        gameState.EndTurn();
    }

    void Update()
    {
        Name.text = player.Name.ToString();
        Gold.text = player.Gold.ToString();
        Lumber.text = player.Lumber.ToString();
    }
}
