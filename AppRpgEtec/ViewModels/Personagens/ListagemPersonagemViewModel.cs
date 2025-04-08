using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppRpgEtec.Services.Personagens;
using AppRpgEtec.Models;
using System.Collections.ObjectModel;

namespace AppRpgEtec.ViewModels.Personagens
{
    public class ListagemPersonagemViewModel : BaseViewModel
    {
        private PersonagemService pService;

        public ObservableCollection<Personagem> Personagens { get; set; }

        public ListagemPersonagemViewModel()
        {
            string token = Preferences.Get("UsuarioToken", string.Empty);
            pService = new PersonagemService(token);
            Personagens = new ObservableCollection<Personagem>();
            _ = ObterPersonagens();
        }
        //Próximos elementos da classe aqui
        //Fim da classe
        public async Task ObterPersonagens()
        {
            try //Junto com o Cacth evitará que erros fechem o aplicativo
            {
                Personagens = await pService.GetPersonagensAsync();
                OnPropertyChanged(nameof(Personagens)); //Informará a View que houve carregamento

            }
            catch (Exception ex)
            {
                //Captará o erro para exibir em tela
                await Application.Current.MainPage
                .DisplayAlert("Ops", ex.Message + "Detalhes: " + ex.InnerException, "Ok");

            }
        }
    }
}