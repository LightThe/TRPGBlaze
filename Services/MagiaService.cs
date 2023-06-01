using System.Collections.Generic;
using System.Linq;

public static class MagiaService
{
    static List<Magia> Magias { get; }

    static MagiaService()
    {
        Magias = new List<Magia>{
            new Magia{ Nome = "Ampliar Plantas",
            Descricao = "A vegetação da área (grama, arbustos, árvores, trepadeiras...) aumenta e se emaranha, formando um mato fechado. A área afetada se torna terreno difícil.",
            Tipo = "Divina",
            Nivel = 3,
            TempoExecucao = "Ação Padrão",
            Alcance = "Raio 90m",
            Alvo = "",
            Duracao = "Instantânea",
            TesteResistencia = "nenhum"},

            new Magia{ Nome = "Andar no Ar",
            Descricao = "O alvo desta magia pode caminhar no ar como se fosse terra sólida.",
            Tipo = "Divina",
            Nivel = 4,
            TempoExecucao = "Ação Padrão",
            Alcance = "Toque",
            Alvo = "1 Criatura",
            Duracao = "10 minutos",
            TesteResistencia = "nenhum"},

            new Magia{ Nome = "Despertar",
            Descricao = "Você desperta inteligência humana em um animal ou árvore. Para a magia funcionar, você deve ser bem-sucedido em um teste de Vontade (CD 10 + DV do alvo, ou DV que a árvore terá ao despertar).",
            Tipo = "Divina",
            Nivel = 5,
            TempoExecucao = "1 dia",
            Alcance = "Toque",
            Alvo = "1 animal ou árvore",
            Duracao = "Instantânea",
            TesteResistencia = "nenhum"},
        };
    }

    public static List<Magia> GetAll() => Magias;
    // public static Magia Get(string nome) => Magias.FirstOrDefault(m => m.Nome == nome);

    public static void Add(Magia magia){
        Magias.Add(magia);
    }
    // public static void Delete(string nome){
    //     var magia = Get(nome);
    //     if(magia is null)
    //         return;
        
    //     Magias.Remove(magia);
    // }

    public static IOrderedEnumerable<IGrouping<int,Magia>> GetGroupedByLevel(){
        var queryNiveis = from magia in Magias
                        group magia by magia.Nivel into niveisMagia
                        orderby niveisMagia.Key
                        select niveisMagia;
        return queryNiveis;
    }

}