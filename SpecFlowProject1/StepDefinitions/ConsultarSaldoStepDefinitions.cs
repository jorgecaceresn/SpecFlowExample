using ClassLibrary1;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ConsultarSaldoStepDefinitions
    {
        public ScenarioContext ctx { get; set; }
        public ConsultarSaldoStepDefinitions(ScenarioContext ctx)
        {

            this.ctx = ctx;

        }
        [Given(@"\[Se inicia la cuenta]")]
        public void GivenSeIniciaLaCuenta()
        {
            Cuenta c = new Cuenta();
            ctx.Add("cuenta",c);
        }

        [Given(@"\[Se inicia la cuenta con saldo (.*)]")]
        public void GivenSeIniciaLaCuentaConSaldo(float p0)
        {
            Cuenta c = new Cuenta(p0);
            Console.WriteLine(p0);
            ctx.Add("cuenta", c);
        }

        [When(@"\[Se consulta el saldo]")]
        public void WhenSeConsultaElSaldo()
        {
            Cuenta c = (Cuenta)ctx["cuenta"];
            double saldo = c.saldo;
            ctx.Add("saldo", saldo);
        }

        [Then(@"\[El saldo es (.*)]")]
        public void ThenElSaldoEs(float p0)
        {
            double saldo = (double)ctx["saldo"];
            saldo.Should().Be(p0);
        }

        [Then(@"\[El mensaje saldo es ""([^""]*)""]")]
        public void ThenElMensajeSaldoEs(string p0)
        {
            Cuenta comprador = (Cuenta)ctx["cuenta"];
            Console.WriteLine($"{nameof(ThenElMensajeSaldoEs)}: {p0}");
            Console.WriteLine($"{nameof(ThenElMensajeSaldoEs)}: {comprador.saldoMessage}");
            comprador.saldoMessage.Should().Be(p0);
            
        }

    }
}
