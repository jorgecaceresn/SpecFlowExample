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

        [When(@"\[Se consulta el saldo]")]
        public void WhenSeConsultaElSaldo()
        {
            Cuenta c = new Cuenta();
            double saldo = c.saldo;
            ctx.Add("saldo", saldo);
        }

        [Then(@"\[El saldo es (.*)]")]
        public void ThenElSaldoEs(int p0)
        {
            double saldo = (double)ctx["saldo"];
            saldo.Should().Be(p0);
        }
    }
}
