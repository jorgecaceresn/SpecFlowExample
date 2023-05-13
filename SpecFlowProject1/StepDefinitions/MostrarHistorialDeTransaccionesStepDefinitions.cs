using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class MostrarHistorialDeTransaccionesStepDefinitions
    {
        private List<Transaccion> transacciones;
        private List<Transaccion> historial;

        [Given(@"que he realizado varias transacciones en el pasado")]
        public void DadoQueHeRealizadoVariasTransaccionesEnElPasado(Table table)
        {
            transacciones = new List<Transaccion>();
            foreach (var row in table.Rows)
            {
                var transaccion = new Transaccion
                {
                    Fecha = DateTime.Parse(row["Fecha"]),
                    Monto = decimal.Parse(row["Monto"].Substring(1)),
                    Detalles = row["Detalles"],
                    Exitosa = bool.Parse(row["Exitosa"])
                };
                transacciones.Add(transaccion);
            }
        }

        [When(@"accedo a la sección de historial de transacciones")]
        public void CuandoAccedoALaSeccionDeHistorialDeTransacciones()
        {
            historial = transacciones;
        }

        [Then(@"se debe mostrar una lista de todas mis transacciones")]
        public void EntoncesSeDebeMostrarUnaListaDeTodasMisTransacciones()
        {
            if (transacciones.Count != historial.Count)
                throw new Exception("El número de transacciones en el historial no coincide con el número de transacciones realizadas");
            else
            {
                Console.WriteLine("Fecha\t\tMonto\tDetalles\t\tExitosa");
                foreach (var t in historial)
                {
                    Console.WriteLine($"{t.Fecha}\t{t.Monto}\t{t.Detalles}\t\t{t.Exitosa}");
                }
            }
        }

        [Given(@"tengo al menos una transacción exitosa en mi historial")]
        public void DadoTengoAlMenosUnaTransaccionExitosaEnMiHistorial()
        {
            bool exitosaEncontrada = false;
            foreach (var t in transacciones)
            {
                if (t.Exitosa)
                {
                    exitosaEncontrada = true;
                    break;
                }
            }
            if (!exitosaEncontrada)
                throw new Exception("No se encontró ninguna transacción exitosa en el historial");
        }

        [Then(@"se debe mostrar una lista de mis transacciones exitosas")]
        public void EntoncesSeDebeMostrarUnaListaDeMisTransaccionesExitosas()
        {
            historial = transacciones.FindAll(t => t.Exitosa);
            foreach (var t in historial)
            {
                if (!t.Exitosa)
                    throw new Exception("Se encontró una transacción no exitosa en el historial de transacciones exitosas");
                else
                {
                    Console.WriteLine("Fecha\t\tMonto\tDetalles\t\tExitosa");
                    
                    Console.WriteLine($"{t.Fecha}\t{t.Monto}\t{t.Detalles}\t\t{t.Exitosa}");
                    
                }
            }   
        }

        [Given(@"tengo al menos una transacción fallida en mi historial")]
        public void DadoTengoAlMenosUnaTransaccionFallidaEnMiHistorial()
        {
            bool fallidaEncontrada = false;
            foreach (var t in transacciones)
            {
                if (!t.Exitosa)
                {
                    fallidaEncontrada = true;
                    break;
                }
            }
            if (!fallidaEncontrada)
                throw new Exception("No se encontró ninguna transacción fallida en el historial");
        }

        [Then(@"se debe mostrar una lista de mis transacciones fallidas")]
        public void EntoncesSeDebeMostrarUnaListaDeMisTransaccionesFallidas()
        {
            historial = transacciones.FindAll(t => !t.Exitosa);
            foreach (var t in historial)
            {
                if (t.Exitosa)
                    throw new Exception("Se encontró una transacción exitosa en el historial de transacciones fallidas");
                else
                {
                    Console.WriteLine("Fecha\t\tMonto\tDetalles\t\tFallida");

                    Console.WriteLine($"{t.Fecha}\t{t.Monto}\t{t.Detalles}\t\t{t.Exitosa}");

                }
            }
        }

        
    }

    public class Transaccion
    {
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Detalles { get; set; }
        public bool Exitosa { get; set; }
    }
}
