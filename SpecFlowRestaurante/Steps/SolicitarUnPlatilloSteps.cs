using System;
using TechTalk.SpecFlow;

namespace SpecFlowRestaurante.Steps
{
    [Binding]
    public class SolicitarUnPlatilloSteps
    {
        [Given(@"que estoy en una mesa y tengo una carta")]
        public void DadoQueEstoyEnUnaMesaYTengoUnaCarta()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"existen (.*) platillos")]
        public void DadoExistenPlatillos(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"pediria la carne apanada")]
        public void EntoncesPediriaLaCarneApanada()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
