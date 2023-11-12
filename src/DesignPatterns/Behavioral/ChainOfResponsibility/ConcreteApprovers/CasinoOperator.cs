using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.ConcreteApprovers;

public class CasinoOperator : AbstractApprover
{
    public override void ProcessRequest(TransactionRequest request)
    {
        if (request.Amount < 10000)
        {
            Console.WriteLine("Approved by a Casino Operator.");
        }
        else
        {
            Console.WriteLine("The request can't be approved by the Casino Operator. Passing to a Casino Manager.");
            NextApprover.ProcessRequest(request);
        }
    }
}
