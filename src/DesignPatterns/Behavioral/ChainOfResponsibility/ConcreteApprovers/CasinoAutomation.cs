using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.ConcreteApprovers;

public class CasinoAutomation : AbstractApprover
{
    public override void ProcessRequest(TransactionRequest request)
    {
        if (request.Amount < 1000)
        {
            Console.WriteLine("Approved by the Casino Automation.");   
        }
        else
        {
            Console.WriteLine("The request can't be approved by the Casino Automation. Passing to a Casino Operator.");
            NextApprover.ProcessRequest(request);
        }
    }
}
