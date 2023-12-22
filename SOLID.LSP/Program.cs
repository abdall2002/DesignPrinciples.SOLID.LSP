//var account = new Before.FixedDepositAccount("Issam", 10_000);
//account.Withdraw(1000); 

var account = new SOLID.LSP.After.CheckingAccount("Issam", 10_000);
account.Withdraw(1000);

//var account = new After.FixedDepositAccount("Issam", 10_000);
//account.Withdraw(1000); // won't work
Console.ReadKey();