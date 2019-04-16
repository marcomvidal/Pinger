# Pinger

Aplicação Windows Forms para desktop. Testa persistentemente a conectividade com a Internet e avisa com uma caixa de mensagem quando funciona. <br />

## Ferramentas utilizadas
- C# 7.0
- .NET Framework 4.7.2
- MSTest v2 1.4.0
- Moq 4.10.1

## Componentes
- `Models`: Domínio da aplicação e realização dos envios de dados;
- `Views`: Apresentação da aplicação para o usuário;
- `Tests`: Testes unitários e de integração.

## Models
Onde a operação de `Ping` (ICMP Request e Reply) efetivamente ocorre. Opera como uma abstração da classe `Ping` contida no .NET Framework. Também valida o endereço que se deseja testar.

## Views
A camada de apresentação foi desenvolvida em Windows Forms, está contida em `Views` e foi separada nas seguintes partes: <br />
- `MainForm`: Formulário que apresentado ao usuário. Apresenta os resultados das operações no DataGridView; <br />
- `MainPresenter`: Parametrização dos elementos de `MainForm`, de modo a aumentar reúso e concisão do código. <br />
O teste de conectividade pode ser feito com qualquer endereço IPv4 válido. Caso nenhum seja preenchido, ele ocorre por padrão com o DNS Server Primário do Google (8.8.8.8).

## Testes
Todos os métodos de negócio tiveram seus testes automatizados para aumentar a confiabilidade da aplicação. <br />
Testes de validação e auxiliares contêm testes unitários, enquanto que a transação de `Ping` possui testes de integração com cenários válidos e inválidos.