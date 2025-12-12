# Documentação Técnica Detalhada - Smart Auto

## 1. Introdução
Este documento serve como um manual técnico aprofundado do projeto **Smart Auto**. Além de explicar o que o programa faz, detalha **como** o faz, focando-se nas funções nativas do C# (.NET Framework) utilizadas para manipulação de interface, eventos e lógica de programação orientada a objetos.

---

## 2. Arquitetura e Estrutura de Classes

### Polimorfismo e Herança
O projeto utiliza fortemente o conceito de **Polimorfismo**.
*   **Conceito**: A variável `veiculoAtual` é do tipo `Veiculo1` (classe base), mas pode armazenar instâncias de `Carro`, `Mota` ou `Camioneta`.
*   **No Código**:
    ```csharp
    private Veiculo1 veiculoAtual; // Pode ser qualquer veículo
    // ...
    veiculoAtual = new Carro(...); // Agora comporta-se como Carro
    ```
    Isto permite que o código trate todos os veículos de forma genérica (ex: chamar `Acelerar`), mas cada um pode ter comportamentos específicos.

---

## 3. Animação e Movimento (`Location` e `Point`)

A simulação visual do movimento dos veículos é feita manipulando as coordenadas dos objetos no ecrã.

### Propriedade `.Location`
*   **O que é**: É uma propriedade de todos os controlos Windows Forms (como `PictureBox`, `Button`, etc.) que define a posição do canto superior esquerdo do controlo em relação ao seu contentor (o Form ou um Painel).
*   **Como funciona**: A propriedade `Location` aceita uma estrutura do tipo `Point`. Não se pode alterar apenas o X ou o Y diretamente (ex: `pbCarro.Location.X = 10` dá erro). É necessário criar um **novo Ponto**.

### Estrutura `Point`
*   **O que é**: Representa um par ordenado de coordenadas inteiras x e y `(x, y)`.
*   **No Código (Simulação de Movimento)**:
    ```csharp
    // Obtém a posição atual X e soma a velocidade
    int novaPosicaoX = pbVeiculo.Location.X + (int)velocidadeAnimacao;
    
    // Define a nova localização mantendo o Y original (movimento horizontal)
    pbVeiculo.Location = new Point(novaPosicaoX, pbVeiculo.Location.Y);
    ```
    Ao fazer isto repetidamente dentro de um `Timer`, cria-se a ilusão de movimento fluído.

---

## 4. Validação de Dados (`KeyPress` e `Char`)

Para garantir que o utilizador não insere letras num campo de números (ou vice-versa), utilizamos o evento `KeyPress`. Este evento ocorre **antes** de o caractere aparecer na caixa de texto, permitindo-nos bloqueá-lo.

### Propriedade `e.Handled`
*   **Função**: Indica se o evento foi "tratado".
*   **Truque**: Se definirmos `e.Handled = true`, estamos a dizer ao Windows "eu já tratei disto, não faças mais nada". Consequentemente, o Windows **não escreve** o caractere na caixa de texto. É assim que bloqueamos teclas inválidas.

### Métodos da Classe `char`
Utilizamos métodos estáticos da estrutura `char` para verificar o tipo de tecla pressionada:

1.  **`char.IsDigit(e.KeyChar)`**: Verifica se é um número (0-9).
2.  **`char.IsLetter(e.KeyChar)`**: Verifica se é uma letra (a-z, A-Z).
3.  **`char.IsControl(e.KeyChar)`**: Verifica se é uma tecla de controlo (como **Backspace**, Enter, Esc). É crucial permitir isto, senão o utilizador não consegue apagar o que escreveu!

**Exemplo Prático (Bloquear Letras em Campos Numéricos):**
```csharp
// Se NÃO for dígito E NÃO for controlo (backspace)
if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
{
    // Bloqueia a entrada
    e.Handled = true; 
}
```

---

## 5. Temporização (`Timer`)

O componente `Timer` (`timerMovimento`) é o "coração" da simulação.

*   **Evento `Tick`**: É disparado repetidamente num intervalo definido (propriedade `Interval`, geralmente em milissegundos).
*   **Lógica do Loop Infinito**:
    O código verifica se o veículo saiu do ecrã (`Location.X > painelSimulacao.Width`). Se sim, "teletransporta" o veículo para o lado esquerdo (coordenada negativa), criando um ciclo contínuo.
    ```csharp
    if (pbVeiculo.Location.X > painelSimulacao.Width)
    {
        // Move para a esquerda, fora da visão, para entrar novamente
        pbVeiculo.Location = new Point(-pbVeiculo.Width, pbVeiculo.Location.Y);
    }
    ```

---

## 6. Interfaces e Classes Abstratas

### `abstract class VeiculoMotorizado`
Define um modelo que **não pode ser instanciado diretamente**. Serve apenas para ser herdado. Obriga todas as classes filhas a terem o método `EncherTanque`.

### `interface ISensor`
Funciona como um "contrato".
*   As classes `Carro` e `Camioneta` assinam este contrato (`: ISensor`), o que as obriga a ter o método `DetectarObstaculos()`.
*   A classe `Mota` **não** assina o contrato, logo não tem sensores. Isto demonstra como adicionar funcionalidades extra apenas a alguns tipos de veículos.

---

## 7. Outras Funções Importantes

### `MessageBox.Show()`
Utilizada para dar feedback ao utilizador. É uma janela modal (bloqueia o resto da aplicação até ser fechada).
*   **Uso**: Erros de validação, avisos de falta de combustível, ou sucesso na criação de veículos.

### `Application.Exit()`
Encerra completamente a aplicação e liberta todos os recursos da memória. Usado no botão "Sair".

### `double.TryParse()`
Uma forma segura de converter texto em números.
*   **Diferença para `double.Parse()`**: O `Parse` faz o programa "crashar" se o texto for inválido (ex: "abc"). O `TryParse` tenta converter e devolve `false` se falhar, permitindo mostrar uma mensagem de erro amigável sem fechar o programa.

---

## 8. Download

O executável do projeto pode ser encontrado no caminho abaixo.
[Descarregar Executável (Projeto Smart-Auto.exe)](./bin/Debug/Projeto%20Smart-Auto.exe)

