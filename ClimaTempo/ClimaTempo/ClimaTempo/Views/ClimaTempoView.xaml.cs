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

        public ClimaTempoService PegarTempo = new ClimaTempoService();

        private async void OnClickPesquisar(object sender, EventArgs e)
        {
            await PegarTempo.ObterClima("Osasco");
        }
    }
}