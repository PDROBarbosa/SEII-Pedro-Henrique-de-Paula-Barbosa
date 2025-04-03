# SEII-RodrigoMialichiTriboni


Resumo sobre Design Patterns, POO, Refatoração de Código e UML
1. O que é Design Pattern
Design Patterns (ou padrões de projeto) são soluções reutilizáveis para problemas comuns em design de software. Eles foram formalizados para ajudar desenvolvedores a resolver problemas recorrentes de maneira eficaz e eficiente, mantendo a consistência e a clareza no código. Design Patterns não são trechos de código, mas sim abordagens que podem ser aplicadas em diversos contextos.

2. Associação com POO
Os Design Patterns estão intimamente ligados à Programação Orientada a Objetos (POO), já que muitas dessas soluções utilizam conceitos fundamentais da POO, como herança, encapsulamento e polimorfismo. A POO oferece um ambiente propício para a aplicação de Design Patterns, pois permite a criação de estruturas modulares e reutilizáveis, facilitando a manutenção e expansão dos sistemas.

3. Refatoração de Código e o Papel dos Design Patterns
Refatoração de código é o processo de melhorar a estrutura interna do código sem alterar seu comportamento externo. Durante essa etapa, os Design Patterns podem ser usados para reorganizar o código de forma mais eficiente, melhorando sua legibilidade, reduzindo a complexidade e eliminando redundâncias. Na construção inicial de sistemas, os Design Patterns auxiliam no planejamento e na organização do código, o que torna o desenvolvimento mais estruturado e escalável.

4. O que é UML e seus Grupos Principais
UML (Unified Modeling Language) é uma linguagem de modelagem padrão utilizada para representar visualmente a estrutura e o comportamento de um sistema. A UML é dividida em três grupos principais:

Diagramas Estruturais: representam a estrutura estática do sistema, como classes e objetos.
Diagramas Comportamentais: mostram o comportamento dinâmico do sistema, como interações e estados.
Diagramas de Interação: detalham a comunicação entre os objetos, como sequências de mensagens e fluxos de dados.
5. Três Grupos Principais e os 8 Design Patterns do Vídeo 3
Os Design Patterns são organizados em três grupos principais:

Padrões Criacionais: lidam com a criação de objetos, proporcionando flexibilidade e reutilização.
Padrões Estruturais: focam em como os objetos e classes são compostos para formar estruturas maiores.
Padrões Comportamentais: abordam a comunicação entre objetos e classes.
Os 8 Design Patterns apresentados no vídeo 3, com suas propriedades, são:

Singleton: garante que uma classe tenha apenas uma instância.
Factory Method: define uma interface para criar objetos, mas permite que as subclasses alterem o tipo de objeto que será criado.
Abstract Factory: cria famílias de objetos relacionados sem depender de classes concretas.
Builder: separa a construção de um objeto complexo da sua representação.
Prototype: permite a criação de novos objetos a partir de instâncias já existentes (prototipagem).
Adapter: permite que classes com interfaces incompatíveis trabalhem juntas.
Bridge: separa uma abstração da sua implementação para que as duas possam variar independentemente.
Strategy: define uma família de algoritmos e permite que eles sejam substituídos independentemente.
6. Exemplos dos Vídeos 5 e 6 e a Solução com Design Patterns
Nos vídeos 5 e 6, foram apresentados exemplos que demonstram como os Design Patterns podem ajudar na solução de problemas práticos:

Exemplo Vídeo 5: Problema relacionado à necessidade de criar múltiplas instâncias de uma classe de forma controlada. Foi aplicado o Design Pattern Factory Method, o que permitiu definir uma maneira flexível de criar instâncias diferentes de classes relacionadas, sem expor detalhes internos ao código cliente.
Exemplo Vídeo 6: Problema que exigia a criação de uma estrutura que pudesse ser facilmente estendida sem modificações diretas. Aqui, foi utilizado o Design Pattern Decorator, que permitiu adicionar funcionalidades a objetos individualmente e de forma dinâmica, mantendo o código modular e escalável.
Ambos os exemplos demonstraram como o uso de Design Patterns pode facilitar a manutenção, promover o reuso de código e tornar o sistema mais fácil de entender e estender.