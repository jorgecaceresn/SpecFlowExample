using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TransferenciaDeDineroEnYapeStepDefinitions
    {
        [Given(@"que el Usuario A ha ingresado a la aplicación Yape")]
        public void GivenQueElUsuarioAHaIngresadoALaAplicacionYape()
        {
            // Implementación: Lógica para que el Usuario A ingrese a la aplicación Yape
            Console.WriteLine("El Usuario A ha ingresado a la aplicación Yape.");
        }

        [Given(@"el Usuario A ha ingresado su número de teléfono y PIN")]
        public void GivenElUsuarioAHaIngresadoSuNumeroDeTelefonoYPIN()
        {
            // Implementación: Lógica para que el Usuario A ingrese su número de teléfono y PIN
            Console.WriteLine("El Usuario A ha ingresado su número de teléfono y PIN.");
        }

        [Given(@"el Usuario A se encuentra en la pantalla principal")]
        public void GivenElUsuarioASeEncuentraEnLaPantallaPrincipal()
        {
            // Implementación: Lógica para verificar que el Usuario A se encuentre en la pantalla principal
            Console.WriteLine("El Usuario A se encuentra en la pantalla principal.");
        }

        [Given(@"el Usuario B también ha ingresado a la aplicación Yape")]
        public void GivenElUsuarioBTambienHaIngresadoALaAplicacionYape()
        {
            // Implementación: Lógica para que el Usuario B ingrese a la aplicación Yape
            Console.WriteLine("El Usuario B ha ingresado a la aplicación Yape.");
        }

        [Given(@"el Usuario B ha ingresado su número de teléfono y PIN")]
        public void GivenElUsuarioBHaIngresadoSuNumeroDeTelefonoYPIN()
        {
            // Implementación: Lógica para que el Usuario B ingrese su número de teléfono y PIN
            Console.WriteLine("El Usuario B ha ingresado su número de teléfono y PIN.");
        }

        [Given(@"el Usuario B se encuentra en la pantalla principal")]
        public void GivenElUsuarioBSeEncuentraEnLaPantallaPrincipal()
        {
            // Implementación: Lógica para verificar que el Usuario B se encuentre en la pantalla principal
            Console.WriteLine("El Usuario B se encuentra en la pantalla principal.");
        }
        [When(@"el Usuario A selecciona la opción de ""([^""]*)""")]
        public void WhenElUsuarioASeleccionaLaOpcionDe(string opcion)
        {
            // Implementación: Lógica para que el Usuario A seleccione la opción específica
            Console.WriteLine("El Usuario A ha seleccionado la opción: " + opcion);
        }

        [When(@"el Usuario A ingresa los datos de la transferencia:")]
        public void WhenElUsuarioAIngresaLosDatosDeLaTransferencia(Table table)
        {
            // Implementación: Lógica para que el Usuario A ingrese los datos de la transferencia
            foreach (var row in table.Rows)
            {
                var destinatario = row["Destinatario"];
                var monto = row["Monto"];
                var descripcion = row["Descripción"];

                // Realizar las acciones necesarias con los datos de la transferencia
                Console.WriteLine("El Usuario A ha ingresado los datos de la transferencia:");
                Console.WriteLine("Destinatario: " + destinatario);
                Console.WriteLine("Monto: " + monto);
                Console.WriteLine("Descripción: " + descripcion);
            }
        }

        [Then(@"se muestra un resumen de la transferencia:")]
        public void ThenSeMuestraUnResumenDeLaTransferencia(Table table)
        {
            // Implementación: Lógica para mostrar un resumen de la transferencia
            foreach (var row in table.Rows)
            {
                var destinatario = row["Destinatario"];
                var monto = row["Monto"];
                var descripcion = row["Descripción"];

                // Mostrar el resumen de la transferencia en la interfaz de usuario
                Console.WriteLine("Se muestra un resumen de la transferencia:");
                Console.WriteLine("Destinatario: " + destinatario);
                Console.WriteLine("Monto: " + monto);
                Console.WriteLine("Descripción: " + descripcion);
            }
        }

        [Then(@"el Usuario A confirma la transferencia")]
        public void ThenElUsuarioAConfirmaLaTransferencia()
        {
            // Implementación: Lógica para que el Usuario A confirme la transferencia
            Console.WriteLine("El Usuario A ha confirmado la transferencia.");
        }

        [Then(@"se muestra un mensaje de confirmación de transferencia exitosa")]
        public void ThenSeMuestraUnMensajeDeConfirmacionDeTransferenciaExitosa()
        {
            // Implementación: Lógica para mostrar un mensaje de confirmación de transferencia exitosa
            Console.WriteLine("Se muestra un mensaje de confirmación de transferencia exitosa.");
        }

        [Then(@"se actualiza el saldo de la cuenta del Usuario A")]
        public void ThenSeActualizaElSaldoDeLaCuentaDelUsuarioA()
        {
            // Implementación: Lógica para actualizar el saldo de la cuenta del Usuario A
            Console.WriteLine("Se actualiza el saldo de la cuenta del Usuario A.");
        }

        [Then(@"se muestra una notificación al Usuario B sobre la transferencia recibida")]
        public void ThenSeMuestraUnaNotificacionAlUsuarioBSobreLaTransferenciaRecibida()
        {
            // Implementación: Lógica para mostrar una notificación al Usuario B sobre la transferencia recibida
            Console.WriteLine("Se muestra una notificación al Usuario B sobre la transferencia recibida.");
        }
    }
}
