# ⏰ Relógio com Tela Cheia

Este projeto é um simples aplicativo de relógio desenvolvido em C# usando Windows Forms. O relógio exibe a hora atual com um fundo preto e texto branco. Além disso, possui um botão para alternar entre o modo de tela cheia e o modo normal.

## 📋 Funcionalidades

- Exibe a hora atual em formato `HH:mm:ss`.
- Fundo preto com texto branco.
- Botão para alternar entre tela cheia e modo normal.

## 🛠️ Como Funciona

1. **Inicialização da Janela**: A janela principal é configurada com um fundo preto e um tamanho inicial de 300x200 pixels.
2. **Label de Hora**: Um `Label` é usado para exibir a hora atual, com fonte Arial de tamanho 24 e cor branca.
3. **Botão de Tela Cheia**: Um `Button` é adicionado na parte inferior da janela para alternar entre os modos de tela cheia e normal.
4. **Timer**: Um `Timer` é configurado para atualizar a hora exibida a cada segundo.

## 🚀 Como Executar

1. **Compilar o Projeto**:
   - Abra o Prompt de Comando.
   - Navegue até o diretório do projeto:
     ```sh
     cd "C:\caminho\para\o\projeto\Csharp\Relogio"
     ```
   - Compile o projeto usando o comando:
     ```sh
     csc /target:winexe MeuRelogio\Relogio.cs MeuRelogio\Program.cs
     ```

2. **Executar o Programa**:
   - Após a compilação, um arquivo executável chamado `Relogio.exe` será gerado no diretório do projeto.
   - Execute o programa digitando:
     ```sh
     Relogio.exe
     ```

## 📂 Estrutura do Projeto

```
Csharp/
├── Relogio/
│   ├── MeuRelogio/
│   │   ├── Relogio.cs
│   │   ├── Program.cs
│   ├── Relogio.sln
│   ├── Relogio.csproj
│   ├── README.md
```

## 📄 Arquivos

- **Relogio.cs**: Contém a classe `Relogio` que define a interface do usuário e a lógica do relógio.
- **Program.cs**: Contém a classe `Program` que é o ponto de entrada do aplicativo.
- **Relogio.sln**: Arquivo de solução do Visual Studio.
- **Relogio.csproj**: Arquivo de projeto do Visual Studio.

## 📝 Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
