using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public abstract class AbstractApprover : IApprover
{
    public IApprover NextApprover { get; set; }
    public virtual void ProcessRequest(TransactionRequest request)
    {
        if (request != null)
        {
            Console.WriteLine("The transaction request is approved on this step.");
        }
        else
        {
            Console.WriteLine("The transaction can't be approved at this moment.");
        }
    }
}
