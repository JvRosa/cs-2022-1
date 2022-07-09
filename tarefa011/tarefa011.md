Padrões de Codificação:
Definição: Padrões que descrevem várias convenções de codificação usadas para implementações inteligíveis, consistentes e com qualidade. O uso de um padrão de codificação é uma prática de desenvolvimento de software extensamente aceita.
Aplicação: São utilizados durante a programação para facilitar os processos de desenvolvimento, remoção de bugs, atividades de validação e manutenção. Seu uso também aumenta a produtividade num projeto, já que a comunicação entre a equipe é facilitada.
Exemplo: Nomes de classes e interfaces em Java, utilizando substantivos, e em caso de nomes compostos, a primeira letra de cada palavra interna é maiúscula. Ex: ContaCliente


Reflexão:
Definição: É um mecanismo que permite que um programa observe ou até mesmo modifique sua estrutura ou comportamento durante a execução.
Aplicação: Geralmente é utilizada na programação orientada a objetos ou durante testes. Utilizada para descobrir entidades durante a execução do código, sendo possível inspecionar classes, métodos, propriedades e tipos de dentro do seu sistema. Isso permite que você crie funcionalidades mais dinâmicas.
Exemplo: Durante um teste, a reflexão pode ajudar a simular as classes, expondo seus comportamentos internos. Normalmente, um método protegido ou privado não poderia ser testado, mas com a reflexão, é possível ignorar a privacidade da classe para que seja pública nos testes.


Programação Defensiva:
Definição: Tem o objetivo de impedir erros gerados pela entrada de dados com a formatação ou uso indevido do programa, evitando que o código seja executado de forma indevida ou a geração de erros em tempo de execução. Os dados manipulados podem ter sua integridade violada caso o código não seja feito com programação defensiva em mente.
Aplicação: Ao construir um sistema ou componente, é sábio validar qualquer dado enviado por fontes externas para garantir que o fluxo esperado dos dados seja seguido.
Exemplo: Utilizar métodos que validam dados, como por exemplo ValidateEmail para confirmar se um email é válido ou não. Caso essas validações não fossem feitas na entrada de dados, elas teriam de ocorrer em outros diversos pontos da aplicação para garantir que os valores estejam sempre corretos.