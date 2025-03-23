# AluguerAutomoveis
### Unidade Curricular de Armazenamento e Acesso a Dados

## Introdução

O presente relatório documenta o trabalho realizado no âmbito da Unidade Curricular de Armazenamento e Acesso a Dados, onde explorámos os princípios e as técnicas de modelação e manipulação de bases de dados relacionais através da linguagem SQL e a representação gráfica a partir de um diagrama entidade-relação (ER). Este trabalho teve como ponto de partida a análise e compreensão de um domínio de negócio, permitindo a criação de um modelo gráfico adequado que serviu como base para o desenvolvimento de uma base de dados funcional.

Inicialmente, foi realizada uma explicação detalhada do negócio associado ao conjunto de dados trabalhados. Este passo foi fundamental para garantir que a estrutura da base de dados refletisse com precisão os processos, as entidades e as interações. Com base nessa análise, foi elaborado um diagrama entidade-relação, que proporcionou uma visão clara das entidades, dos seus atributos e das relações existentes entre elas. Este modelo serviu como base para a implementação da base de dados e para a realização das consultas SQL.

Durante este projeto, foram desenvolvidas diversas consultas, abrangendo desde operações simples até processos mais avançados, com o objetivo de consolidar os conhecimentos adquiridos e aplicá-los a cenários reais de análise e gestão de dados. As atividades realizadas incluíram o uso de instruções SQL como `SELECT`, `JOIN`, `GROUP BY`, `HAVING` e `SUBQUERY`, garantindo uma exploração abrangente das funcionalidades da linguagem.

Com a base de dados criada no SQL Server, retirada do modelo desenvolvido no Visual Paradigm, pretendemos criar um sistema de gestão dessa base de dados, utilizando C# e Windows Forms. Este sistema tem como objetivo permitir a interação eficiente e segura com os dados, proporcionando funcionalidades como registo, pesquisa, edição e eliminação de entidades. Para tal, pretendemos adotar a arquitetura N-Tier, promovendo a separação de responsabilidades entre as camadas.

### Objetivos Principais

- Compreender o domínio do negócio, de forma a traduzir as suas necessidades para uma estrutura de base de dados eficiente e representativa;
- Elaborar um diagrama entidade-relação que represente fielmente o modelo do negócio em análise;
- Desenvolver competências práticas na utilização da linguagem SQL para manipular e consultar bases de dados;
- Explorar técnicas avançadas de consultas;
- Analisar dados de forma eficiente, extraindo informações úteis e relevantes para a resolução de problemas específicos;
- Aplicar os conhecimentos teóricos adquiridos, transferindo-os para um contexto prático que simule cenários do mundo real;
- Criar uma base de dados SQL funcional e eficiente, a partir de um modelo gráfico desenvolvido no Visual Paradigm, garantindo que esta reflete com precisão as necessidades e processos do domínio do negócio;
- Desenvolver um sistema de gestão funcional, utilizando C# e Windows Forms, que permita a interação com a base de dados de forma eficiente, segura e alinhada com as necessidades do negócio.

---

## Negócio de Aluguer de Automóveis

O processo inicia-se com o cliente, que pode ser um indivíduo ou até mesmo uma outra organização, que estabelece contacto com a empresa de aluguer de automóveis. Este contacto pode ser estabelecido de diversos modos, nomeadamente balcões físicos da empresa, plataformas online ou mesmo através de agências de viagem, que neste caso funcionam como mediadoras.

O interesse do potencial cliente traduz-se na procura por alugar um veículo de forma rápida e segura, atendendo também a necessidades específicas como o tipo de viagem que deseja realizar com o veículo alugado, desde eventos empresariais, eventos de lazer, transporte ocasional de mercadorias ou até mesmo para suprir a falta temporária de um veículo próprio.

Para tal, cada cliente apresenta uma proposta individual, de acordo com certos critérios que o próprio impõe, como por exemplo, tipo de veículo (ligeiro, pesado de passageiro ou de mercadorias, podendo ainda optar pelo aluguer de um reboque), marca do veículo, capacidade e preço. Após a formalização da proposta pelo cliente, que pode ser feita presencialmente ou online, serão recolhidas as suas informações pessoais (nome, contacto, morada, entre outros), bem como dados relacionados ao aluguer, como o período que o cliente deseja ter o veículo em sua posse e o local de levantamento e devolução do veículo.

Após a reserva, o cliente recebe um documento que contém os detalhes do aluguer. Este documento pode incluir diversos fatores como o custo diário de aluguer, a quilometragem permitida, a cobertura de seguros ou até mesmo possíveis extras, como sistemas de retenção para crianças, dispositivo de GPS, condutor extra, ETC Card, possibilidade de saída de território nacional ou até mesmo europeu, possibilidade de percorrer mais quilómetros do que os permitidos pelo valor base pago, entre outros. Este termo poderá ser aceite ou recusado, com possível negociação, pelo cliente, não tendo este processo qualquer custo para o mesmo. Caso o cliente aceite os termos propostos no documento, será dado início ao processo de compra de aluguer do veículo, requerendo neste momento o título de condução válido para o veículo específico que pretende alugar, documento de identificação pessoal e até, em alguns casos, um cartão de crédito/débito, para a caução e o pagamento de todos os custos envolvidos. É ainda analisado com o cliente se este pretende a realização de um seguro contra todos os riscos, que, na eventualidade de um sinistro, cobre o mesmo, evitando o pagamento de caução. Deste modo, todos os dados serão analisados, processados e validados, podendo assim depois ser feita a entrega do veículo.

O veículo é entregue ao cliente no local previamente acordado, seja em um dos balcões da empresa, num aeroporto ou até mesmo em qualquer local nacional num raio máximo de 50 quilómetros do balcão da empresa mais próximo. Antes da entrega, em conjunto com o cliente, possibilitando a este, por motivos de segurança, o registo fotográfico do mesmo, é feita uma análise geral ao veículo, verificando a integridade do veículo e as condições com que este é entregue (nível de combustível, limpeza, quilometragem e até mesmo possíveis danos já existentes no veículo). Estes dados são registados num relatório e posteriormente são assinados pelo cliente, que concorda com a veracidade dos dados.

Durante o aluguer do veículo, o cliente compromete-se ao cuidado do veículo, respeitando as normas de trânsito e os termos do documento previamente assinado. Na eventualidade de um sinistro, por exemplo, algum dano ou acidente com o veículo, o cliente deverá contactar de imediato a empresa, explicando o ocorrido, procedendo à realização das medidas orientadas pela mesma. Nestes casos, é realizada uma reunião com o cliente, onde será estipulado se o cliente ficará sem o valor parcial ou total da caução, dependendo do ocorrido.

No final do período de aluguer, o cliente deverá proceder à devolução do veículo no local acordado. Seguidamente, a empresa realiza uma nova inspeção à integridade do veículo, comparando-a com o relatório inicial. Na ocorrência de danos não reportados ou na eventualidade do veículo ser devolvido com o nível de combustível e/ou limpeza menor que o acordado, serão aplicadas taxas adicionais pela empresa, cobradas do cartão de crédito/débito fornecido inicialmente.

Os movimentos financeiros no aluguer de veículos envolvem diversas transações que são geradas ao longo do contrato de aluguer. O pagamento principal refere-se ao custo diário ou semanal pelo uso do veículo, acordado previamente no momento da reserva. Além deste valor base, como referido, o cliente também pode ter de pagar uma caução, para cobrir eventuais danos ou custos adicionais não previstos. Caso sejam identificados problemas, a empresa pode emitir um ajuste, o que significa que o cliente poderá receber um reembolso por valores pagos em excesso ou, por outro lado, ter que efetuar pagamentos adicionais, tudo isso devidamente documentado e comunicado ao cliente.

Assim, a finalização do processo de aluguer inicia-se com a devolução do veículo e a liquidação de todos os valores. Após a inspeção final do veículo e a verificação de que o mesmo foi devolvido nas condições esperadas, a empresa procede à devolução da caução e à emissão do recibo de pagamento final. Caso todos os valores estejam corretos e não haja discrepâncias entre o estado do veículo no início e no fim do aluguer, o contrato é assim encerrado sem qualquer intervenção adicional.

Contudo, em alguns casos, pode ser necessário um cuidado maior, podendo assim ser aberto um processo de pós-aluguer. Este processo envolve situações em que o cliente questiona valores cobrados, como danos imputados ou taxas adicionais que não estavam claramente especificadas. O cliente tem o direito de solicitar reembolsos ou até mesmo contestar cobranças que considere indevidas. A empresa de aluguer tem a responsabilidade de analisar essas reclamações, revisando o contrato, os relatórios de inspeção, e outros, para garantir que as cobranças estão de acordo com os termos que foram previamente acordados, encerrando assim o processo de aluguer de forma definitiva e justa para ambas as partes.

