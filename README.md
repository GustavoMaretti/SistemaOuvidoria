# SistemaOuvidoria
Sistema de chamados inspirado em uma ouvidoria municipal, desenvolvido em C#/.NET 6 como projeto de estudo. Aplica fundamentos de POO (herança, interfaces, encapsulamento), coleções, LINQ e tratamento de exceções.


## Progresso da Sprint

### ✅ OUV-01 — Modelo de domínio (Manifestação)
**Status:** Concluído

- Implementada a hierarquia `Manifestacao` (abstrata) com subclasses `Denuncia`, `Reclamacao`, `Sugestao` e `Elogio`.
- Criada a interface `IPrioritizavel` (`CalcularPrioridade()`), implementada por `Denuncia` e `Reclamacao` — `Sugestao` e `Elogio` não participam do fluxo de priorização.
- Construtor de `Manifestacao` centraliza a inicialização de `Protocolo`, `DataAbertura` e `Status`, e valida que `Solicitante` (Cidadao) não seja nulo, lançando `ArgumentNullException` caso contrário — garante que nenhum objeto nasça em estado inválido.
- `GerarProtocolo()` usa formato `yyyyMMddHHmmssfff` (inclui milissegundos) para reduzir colisão de protocolos gerados em sequência rápida.
- Cada subclasse repassa `Solicitante` para a base via `base(solicitante)` e adiciona apenas seus atributos exclusivos (`Gravidade` em Denúncia, `Reincidente` em Reclamação).
