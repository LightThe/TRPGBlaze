using System.Collections.Generic;
using System;

public class Atributo{
    public string nomeAtr { get; set; }
    public string nomeRdzAtr { get; set; }
    public int valorAtr { get; set; }
    public double modAtr { get; set; }
    
    public Atributo(string nomeAtributo, int valorAtributo){
        nomeAtr = nomeAtributo;
        nomeRdzAtr = nomeAtributo.ToUpper().Substring(0,3);
        valorAtr = valorAtributo;
        this.UpdateModificador();
    }

    public void UpdateModificador(){
        this.modAtr = ((2*this.valorAtr) + (Math.Pow(-1, this.valorAtr)) - 21)/4;
    }
}