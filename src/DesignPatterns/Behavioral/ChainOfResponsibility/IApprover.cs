namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public interface IApprover
{
    IApprover NextApprover { get; set; }
    void ProcessRequest(TransactionRequest request);
}
