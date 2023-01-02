namespace InjecaoDependencia.Abstractions;

// Todas as subinterfaces de IOperation nomeiam o tempo de vida de serviço pretendido.
public interface IOperation
{
    string OperationId { get; }
}