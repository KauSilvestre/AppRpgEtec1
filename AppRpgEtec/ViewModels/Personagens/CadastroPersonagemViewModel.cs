using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppRpgEtec.Services.Personagens;

namespace AppRpgEtec.ViewModels.Personagens
{
    public class CadastroPersonagemViewModel : BaseViewModel
    {/*(1) Declaração da propriedade que referência a classe de serviço e (2) Criação do 
      Construtor para
      receber o objeto que será enviado da View para alimentar esta classe, resgate do 
       token da aplicação para passar para a instância do serviço.*/
        //1
        private PersonagemService pService;
        //2
        public CadastroPersonagemViewModel()
        {
            string token = Preferences.Get("UsuarioToken", string.Empty);
            pService = new PersonagemService(token);
        }
        private int id;
        private int inteligencia;
        private string nome;
        private int disputas;
        private int pontosvida;
        private int vitorias;
        private int forca;
        private int derrotas;
        private int defesa;
        //Control+R,E Para criar isso 
        public int Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged()
           ;
            }
        }
        public int Inteligencia
        {
            get => inteligencia;
            set
            {
                inteligencia = value;
                OnPropertyChanged();
            }
        }
        public string Nome { get => nome; set { nome = value; OnPropertyChanged(); } }
        public int Disputas { get => disputas; set { disputas = value; OnPropertyChanged(); } }
        public int Pontosvida { get => pontosvida; set { pontosvida = value; OnPropertyChanged(); } }
        public int Vitorias { get => vitorias; set { vitorias = value; OnPropertyChanged(); } }
        public int Forca { get => forca; set { forca = value; OnPropertyChanged(); } }
        public int Derrotas { get => derrotas; set { derrotas = value; OnPropertyChanged(); } }
        public int Defesa
        {
            get => defesa; set
            {
                defesa = value; OnPropertyChanged()
    ;
            }
        }
    }
}

