Feature: Pagar con yape

Se debita del comprador un monto que será abonado en el vendedor

@tag3
Scenario: [Saldo suficiente]
	Given [Se inicia cuenta de comprador teniendo saldo 100]
	And [Se inicia la cuenta del vendedor teniendo saldo 200]
	When [Se debita 50 del comprador]
	And [Se abona 50 al vendedor]
	Then [El saldo en el comprador es 50] 
	And [El saldo en el vendedor es 250]
Scenario: [Saldo insuficiente]
	Given [Se inicia cuenta de comprador teniendo saldo 49]
	And [Se inicia la cuenta del vendedor teniendo saldo 200]
	When [Se debita 50 del comprador]
	Then [El mensaje es "Saldo insuficiente"] 
	
