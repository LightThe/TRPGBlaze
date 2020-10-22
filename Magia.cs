using System.Collections.Generic;
using System.Linq;
public class Magia{
    public string nomeMagia { get; set; }
    public string descMagia { get; set; }
    public int nivelMagia { get; set; }
    public string tempoExecucao { get; set; }
    public string alcance { get; set; }
    public string alvo { get; set; }
    public string duracao { get; set; }
    public string testeResistencia { get; set; }

    public void Clear(){
        this.nomeMagia = "";
        this.descMagia = "";
        this.nivelMagia = 0;
        this.tempoExecucao = "";
        this.alcance = "";
        this.alvo = "";
        this.duracao = "";
        this.testeResistencia = "";
    }
    public static IOrderedEnumerable<IGrouping<int,Magia>> AgruparPorNivel(IList<Magia> listaMagias){
        var queryNiveis = from magia in listaMagias
                        group magia by magia.nivelMagia into niveisMagia
                        orderby niveisMagia.Key
                        select niveisMagia;
        return queryNiveis;
    }
}