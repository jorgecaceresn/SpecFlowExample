Feature: Mostrar historial de transacciones

  Como usuario de Yape
  Quiero poder ver un historial de mis transacciones pasadas
  Para tener un registro detallado de mis pagos y transferencias

Background:
  Given que he realizado varias transacciones en el pasado
  | Fecha       | Monto | Detalles                | Exitosa |
	| 2023-05-10  | $50   | Pago de servicio        | true    |
	| 2023-05-09  | $20   | Compra en línea         | true    |
	| 2023-05-08  | $30   | Pago de factura         | true    |
	| 2023-05-07  | $100  | Error en la transferencia | false   |

Scenario: Ver historial de transacciones
  When accedo a la sección de historial de transacciones
  Then se debe mostrar una lista de todas mis transacciones


Scenario: Ver historial de transacciones exitosas
  Given tengo al menos una transacción exitosa en mi historial
  When accedo a la sección de historial de transacciones
  Then se debe mostrar una lista de mis transacciones exitosas


Scenario: Ver historial de transacciones fallidas
  Given tengo al menos una transacción fallida en mi historial
  When accedo a la sección de historial de transacciones
  Then se debe mostrar una lista de mis transacciones fallidas
  
