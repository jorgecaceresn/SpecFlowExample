using ClassLibrary1;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class PagarConYapeStepDefinitions
    {
        public ScenarioContext ctx { get; set; }
        public PagarConYapeStepDefinitions(ScenarioContext ctx)
        {

            this.ctx = ctx;

        }
        [Given(@"\[Se inicia cuenta de comprador]")]
        public void GivenSeIniciaCuentaDeComprador()
        {
            Cuenta comprador = new Cuenta();
            ctx.Add("comprador", comprador);
        }

        [Given(@"\[Se inicia cuenta de comprador teniendo saldo (.*)]")]
        public void GivenSeIniciaCuentaDeCompradorTeniendoSaldo(float p0)
        {
            Cuenta comprador = new Cuenta(p0);
            ctx.Add("comprador", comprador);
        }

        [Given(@"\[Se inicia la cuenta del vendedor teniendo saldo (.*)]")]
        public void GivenSeIniciaLaCuentaDelVendedorTeniendoSaldo(float p0)
        {
            Cuenta vendedor = new Cuenta(p0);
            ctx.Add("vendedor", vendedor);
        }


        [Given(@"\[Se inicia la cuenta del vendedor]")]
        public void GivenSeIniciaLaCuentaDelVendedor()
        {
            Cuenta vendedor = new Cuenta();
            ctx.Add("vendedor", vendedor);
        }

        

        [When(@"\[Se debita (.*) del comprador]")]
        public void WhenSeDebitaDelComprador(float p0)
        {
            Cuenta comprador = (Cuenta)ctx["comprador"];
            comprador.debitarCuenta(p0);

        }

        [When(@"\[Se abona (.*) al vendedor]")]
        public void WhenSeAbonaAlVendedor(float p0)
        {
            Cuenta vendedor = (Cuenta)ctx["vendedor"];
            vendedor.abonarCuenta(p0);
        }        

        [Then(@"\[El saldo en el comprador es (.*)]")]
        public void ThenElSaldoEnElCompradorEs(float p0)
        {
            Cuenta comprador = (Cuenta)ctx["comprador"];
            comprador.saldo.Should().Be(p0);
        }

        [Then(@"\[El saldo en el vendedor es (.*)]")]
        public void ThenElSaldoEnElVendedorEs(float p0)
        {
            Cuenta vendedor = (Cuenta)ctx["vendedor"];
            vendedor.saldo.Should().Be(p0);
        }
    

        [Then(@"\[El mensaje debito es ""([^""]*)""]")]
        public void ThenElMensajeDebitoEs(string p0)
        {
            Cuenta comprador = (Cuenta)ctx["comprador"];
            comprador.debitoMessage.Should().Be(p0);
            Console.WriteLine($"{nameof(ThenElMensajeDebitoEs)}: {p0}");           
            
        }
    }
}
