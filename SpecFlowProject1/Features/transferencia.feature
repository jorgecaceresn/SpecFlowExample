Feature: Transferencia de dinero en Yape


   @tag1
  Scenario: Transferencia exitosa de dinero entre usuarios

    Given que el Usuario A ha ingresado a la aplicación Yape
    And el Usuario A ha ingresado su número de teléfono y PIN
    And el Usuario A se encuentra en la pantalla principal

    And el Usuario B también ha ingresado a la aplicación Yape
    And el Usuario B ha ingresado su número de teléfono y PIN
    And el Usuario B se encuentra en la pantalla principal

    When el Usuario A selecciona la opción de "Transferir dinero"
    And el Usuario A ingresa los datos de la transferencia:
      | Destinatario | Monto   | Descripción     |
      | Usuario B    | $50.00  | Pago de deuda   |

    Then se muestra un resumen de la transferencia:
      | Destinatario | Monto   | Descripción     |
      | Usuario B    | $50.00  | Pago de deuda   |

    And el Usuario A confirma la transferencia

    Then se muestra un mensaje de confirmación de transferencia exitosa
    And se actualiza el saldo de la cuenta del Usuario A
    And se actualiza el saldo de la cuenta del Usuario B
    And se muestra una notificación al Usuario B sobre la transferencia recibida