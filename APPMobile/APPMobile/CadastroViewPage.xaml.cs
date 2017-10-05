using APPMobile.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APPMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastroViewPage : ContentPage
	{
        private Pessoa pessoa;

		public CadastroViewPage ()
		{
			InitializeComponent ();

            pessoa = new Pessoa();
		}

        void OnSalvar (object sender, EventArgs args)
        {
            if (string.IsNullOrEmpty(entName.Text))
            {
                DisplayAlert("Erro", "Campo Nome deve ser preenchido", "OK");
                return;
            }
            if (string.IsNullOrEmpty(entEmail.Text))
            {
                DisplayAlert("Erro", "Campo Email deve ser preenchido", "OK");
                return;
            }
            if (string.IsNullOrEmpty(entEndereco.Text))
            {
                DisplayAlert("Erro", "Campo Endereço deve ser preenchido", "OK");
                return;
            }
            if (string.IsNullOrEmpty(entTelefone.Text))
            {
                DisplayAlert("Erro", "Campo Telefone deve ser preenchido", "OK");
                return;
            }

            pessoa.Nome = entName.Text;
            pessoa.Email = entEmail.Text;
            pessoa.Telefone = entTelefone.Text;
            pessoa.Endereco = entEndereco.Text;
        }

        void OnExcluir(object sender, EventArgs args)
        {

        }

        void OnAtualizar(object sender, EventArgs args)
        {

        }
    }
}