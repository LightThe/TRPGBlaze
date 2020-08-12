using System.Collections.Generic;

public class Atributo{
    public string nomeAtr { get; set; }
    public int valorAtr { get; set; }
    public int modAtr { get; set; }

    Dictionary<int, int> modLookup = new Dictionary<int, int>(){
        {1, -5},
        {2, -4},
        {3, -4},
        {4, -3},
        {5, -3},
        {6, -2},
        {7, -2},
        {8, -1},
        {9, -1},
        {10, 0},
        {11, 0},
        {12, 1},
        {13, 1},
        {14, 2},
        {15, 2},
        {16, 3},
        {17, 3},
        {18, 4},
        {19, 4},
        {20, 5},
        {21, 5},
        {22, 6},
        {23, 6},
        {24, 7},
        {25, 7},
    };

    public int CalculaModificador(int valor){
        return modLookup.GetValueOrDefault(valor);
    }
}