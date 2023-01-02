using InjecaoDependencia.Abstractions;
using static System.Guid;

namespace InjecaoDependencia;

// O DefaultOperation implementa todas as interfaces de marcador nomeadas
// e inicializa a propriedade OperationId para os últimos quatro caracteres
// de um novo GUID (identificador exclusivo).
public record class DefaultOperation : 
    ITransientOperation,
    IScopedOperation,
    ISingletonOperation
{
    public string OperationId { get; } = NewGuid().ToString()[^4..];
}