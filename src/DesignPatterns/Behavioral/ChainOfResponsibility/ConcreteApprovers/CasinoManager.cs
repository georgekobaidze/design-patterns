using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.ConcreteApprovers;

public class CasinoManager : AbstractApprover
{
    public override void ProcessRequest(TransactionRequest request)
    {
        if (request.Amount < 100000)
        {
            Console.WriteLine("The request has been approved by the Casino Manager.");
        }
        else
        {
            Console.WriteLine("The request will be approved after 2 working days.");
        }
    }
}
