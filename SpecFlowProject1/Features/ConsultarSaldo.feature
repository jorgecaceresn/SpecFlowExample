Feature: Consultar saldo

Para el comprador o vendedor

@tag333
Scenario: [Cuenta nueva con saldo 0]
	Given [Se inicia la cuenta]
	When [Se consulta el saldo]
	Then [El saldo es 0]

