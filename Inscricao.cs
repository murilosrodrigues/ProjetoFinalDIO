using System.Collections.Generic;

namespace ProjetoFinalDio
{
    public class Inscricao
    {

        public string _Nome { get; set; } = string.Empty;
        public int _Idade { get; set; } = -1;
        public string _FaixaAtual { get; set; } = string.Empty;
        public string _ProximaFaixa { get; set; }
        public int _AulasDadas { get; set; } = -1;
        public int _AulasParticipadas { get; set; } = -1;

        public List<string> _ListaFaixas { get; } = new List<string>() { "Branca", "Amarela", "Vermelha", "Laranja", "Verde", "Roxa", "Marrom", "Preta" };

        public Inscricao()
        {
            this._Nome = "Jon";
            this._Idade = 15;
            this._FaixaAtual = "Amarela";
            this._AulasDadas = 40;
            this._AulasParticipadas = 19;
        }

        public bool ValidarNome(string nome)
        {
            return false;
        }

        public string PrecisaNomeResponsavel()
        {

            return string.Empty;
        }

        public bool FaixaAtualEValida()
        {
            return false;
        }

        public string ExisteProximaFaixa()
        {
            return string.Empty;
        }

        public bool EstaAptoParaFazerExame()
        {
            return false;
        }

    }

    

}
