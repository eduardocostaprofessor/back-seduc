/* 
    -- Atividade a ser feita dentro da pasta Pilares
    -- Criar as seguintes classes: Conta, ContaCorrente e ContaPoupanca

    * Classe abstrata Conta 
        Propriedades:
            Saldo float, Titular string 
        Métodos abstratos: 
            Sacar(float valor) 
            Depositar(float valor)

    * Classe concreta ContaPoupanca - Herda de Conta
        Propriedades:
            limiteSaque int - quantas vezes pode sacar
            rendimento float - representa o percentual aplicado ao depósito
        Métodos:
            Sacar(float valor)      - implementa da classe pai
            Depositar(float valor)  - implementa da classe pai

    Classe concreta ContaCorrente - Herda de Conta
        Propriedades:
            limite float - representa o valor adicional ao saldo
        Métodos:
            Sacar(float valor)      - implementa da classe pai
            Depositar(float valor)  - implementa da classe pai
            Transferir(float valor, ContaCorrente contaDestino) - representa
*/