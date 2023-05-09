Feature: Consultar saldo

Para el comprador o vendedor

@tag1
Scenario: [Cuenta nueva con saldo 0]
	Given [Se inicia la cuenta]
	When [Se consulta el saldo]
	Then [El saldo es 0.0]

Scenario: [Cuenta con saldo ya existente]
	Given [Se inicia la cuenta con saldo 100.0]
	When [Se consulta el saldo]
	Then [El saldo es 100.0]

Scenario: [Iniciar cuenta con saldo negativo]
	Given [Se inicia la cuenta con saldo -100.0]
	When [Se consulta el saldo]
	Then [El mensaje saldo es "La cuenta no puede tener saldo negativo"]

