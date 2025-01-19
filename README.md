# DIO - Trilha .NET - Explorando a linguagem C#
www.dio.me

## Desafio de Projeto
Este projeto foi desenvolvido como parte do módulo *Explorando a Linguagem C#*, da trilha .NET da DIO. Ele implementa um sistema de hospedagem completo, com funcionalidades de gestão de reservas, cálculo de diárias e autenticação.

## Funcionalidades
### Sistema de Reserva
- **Cadastro de Hóspedes**:
  - A classe `Pessoa` representa os hóspedes, permitindo definir nome, sobrenome e exibir o nome completo em maiúsculas.
- **Cadastro de Suítes**:
  - A classe `Suite` permite configurar o tipo, a capacidade e o valor da diária.
- **Gestão de Reservas**:
  - A classe `Reserva` conecta hóspedes e suítes, validando a capacidade da suíte com relação ao número de hóspedes.
  - Métodos principais:
    - `ObterQuantidadeHospedes`: Retorna o número total de hóspedes.
    - `CalcularValorDiaria`: Calcula o valor total da reserva, aplicando desconto de 10% para períodos de 10 dias ou mais.

### Regras de Negócio
1. Não é possível reservar uma suíte com capacidade menor do que a quantidade de hóspedes.
2. O cálculo de valores de diárias considera descontos conforme a duração da estadia.

## Tecnologias Utilizadas
- **Linguagem**: C#
- **Framework**: .NET
- **Padrões**: Programação Orientada a Objetos (POO)

## Como Executar
1. Certifique-se de ter o .NET SDK instalado.
2. Clone este repositório:
   ```bash
   git clone https://github.com/Ntzsbiel/sistema-hospedagem.git
