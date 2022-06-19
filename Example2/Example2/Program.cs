using Example2;
using Example2.Domain;

Lead lead = new Lead();
Manager manager = new Manager();
HeadOf headOf = new HeadOf();

lead.Next(manager);
manager.Next(headOf);

int cashRequesAmount = 11500;
Result result =  lead.PaymentControl(cashRequesAmount);

Console.WriteLine(result.CurrentStep);