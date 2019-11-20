using ClimaTempo.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClimaTempo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClimaTempoView : ContentPage
	{
		public ClimaTempoView ()
		{
			InitializeComponent ();
		}

        public ClimaTempoService ClimaTempo = new ClimaTempoService();

        private void OnClickPesquisar(object sender, EventArgs e)
        {
            PegarDadosClima(txtPesquisa.Text);
        }

        private async void PegarDadosClima(string cidade)
        {
            var dadosClima = await ClimaTempo.ObterClima(cidade);

            txtCidade.Text = dadosClima.NomeCidade;
            txtTemp.Text = dadosClima.Clima.Temperatura;
            txtMin.Text = dadosClima.Clima.TemperaturaMaxima;
            txtMax.Text = dadosClima.Clima.TemperaturaMinina;
            txtHumidade.Text = dadosClima.Clima.Humidade;
        }
    }
}