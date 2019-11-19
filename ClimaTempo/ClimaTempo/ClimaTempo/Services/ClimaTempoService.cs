using ClimaTempo.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClimaTempo.Services
{
    public class ClimaTempoService
    {
        private readonly HttpClient _HttpClient;

        public ClimaTempoService()
        {
            _HttpClient = new HttpClient();
        }

        public async Task<Clima> ObterClima(string cidade)
        {
            try
            {
                string url = $"{Constantes.ApiBaseUrl}{cidade}{Constantes.CodigoPais}&appid={Constantes.AppId}&units=metric";
                HttpResponseMessage response = await _HttpClient.GetAsync($"{Constantes.ApiBaseUrl}{cidade}{Constantes.CodigoPais}&appid={Constantes.AppId}&units=metric");

                if (!response.IsSuccessStatusCode)
                    await App.Current.MainPage.DisplayAlert("Eita Nóis...", "Alguma coisa de errado não deu certo!!!", "Ok");

                var conteudoResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Clima>(conteudoResponse);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
