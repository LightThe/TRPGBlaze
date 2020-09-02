using System.Collections.Generic;

public class Atributo{
    public string nomeAtr { get; set; }
    public string nomeRdzAtr { get; set; }
    public int valorAtr { get; set; }
    public int modAtr { get; set; }

    private Dictionary<int, int> modLookup = new Dictionary<int, int>(){
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

    public Atributo(string nomeAtributo, int valorAtributo){
        nomeAtr = nomeAtributo;
        nomeRdzAtr = nomeAtributo.ToUpper().Substring(0,3);
        valorAtr = valorAtributo;
        modAtr = modLookup.GetValueOrDefault(valorAtributo);
    }

    public void UpdateModificador(){
        this.modAtr = modLookup.GetValueOrDefault(this.valorAtr);
    }

}