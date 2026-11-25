# 🎯 Jogo: Adivinhe o Número (C#)

Um jogo de console interativo desenvolvido em C# como parte dos meus estudos em lógica de programação. O objetivo é adivinhar um número secreto gerado aleatoriamente pelo sistema antes que as chances acabem.

## 🎮 Como Jogar

1. Ao iniciar, o sistema perguntará se você deseja começar (digite `S` para sim ou `N` para não).
2. O sistema vai sortear um número secreto entre 1 e 10.
3. Você tem **4 chances** para adivinhar o número.
4. Digite seu palpite e pressione `Enter`.
5. O sistema avisará se você errou e mostrará quantas chances ainda restam.
6. Se você acertar ou as chances acabarem, o jogo perguntará se você deseja jogar novamente.

## ✨ Funcionalidades

- **Geração Aleatória:** O número secreto muda a cada nova partida.
- **Validação de Entrada:** O sistema impede que o usuário digite letras ou símbolos no lugar de números, evitando que a aplicação quebre (`int.TryParse`).
- **Tratamento de Erros:** As mensagens de erro ficam na tela aguardando o usuário apertar `Enter`, melhorando a experiência visual.
- **Jogar Novamente:** Fluxo contínuo de jogo sem precisar fechar e abrir o console novamente.

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C# (.NET)
- **Ambiente:** Console Application

## 🚀 Como Executar o Projeto

### Pré-requisitos
Você precisará ter instalado em sua máquina:
- [.NET SDK](https://dotnet.microsoft.com/download) (versão 6.0 ou superior)
- Um editor de código (Visual Studio, Visual Studio Code ou Rider)

### Passo a passo

1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/adivinhe-o-numero.git
