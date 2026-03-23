# Sistema de Cálculo de Frete 🚚

Este projeto consiste em uma aplicação desenvolvida em C# utilizando Windows Forms, criada como atividade da disciplina Padrões de Projeto de Software do curso de Análise e Desenvolvimento de Sistemas.

O sistema tem como objetivo realizar o cálculo do valor de frete com base em três informações fornecidas pelo usuário: peso da encomenda, distância da entrega e tipo de frete. A aplicação apresenta uma interface gráfica simples onde os dados são inseridos e, após o processamento, o valor do frete é exibido ao usuário.

Durante o desenvolvimento foram aplicados conceitos de Programação Orientada a Objetos, além de princípios da `arquitetura SOLID`, visando tornar o código mais organizado, modular e fácil de manter. Também foi utilizado o padrão criacional `Factory Method`, responsável por centralizar a criação dos objetos de cálculo de frete.

Cada tipo de frete possui sua própria regra de cálculo, implementada em classes específicas que seguem um contrato comum definido por uma interface. Dessa forma, o sistema se torna flexível e extensível, permitindo a adição de novos tipos de frete sem a necessidade de modificar a estrutura principal da aplicação.
