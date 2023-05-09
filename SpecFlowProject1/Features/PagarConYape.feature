Feature: Pagar con yape

Se debita del comprador un monto que será abonado en el vendedor

@tag3
Scenario: [Saldo suficiente]
	Given [Se inicia cuenta de comprador teniendo saldo 100.0]
	And [Se inicia la cuenta del vendedor teniendo saldo 200.0]
	When [Se debita 50.0 del comprador]
	And [Se abona 50.0 al vendedor]
	Then [El saldo en el comprador es 50.0] 
	And [El saldo en el vendedor es 250.0]
Scenario: [Saldo insuficiente]
	Given [Se inicia cuenta de comprador teniendo saldo 49.0]
	And [Se inicia la cuenta del vendedor teniendo saldo 200.0]
	When [Se debita 50.0 del comprador]
	Then [El mensaje debito es "Saldo insuficiente"] 
	
