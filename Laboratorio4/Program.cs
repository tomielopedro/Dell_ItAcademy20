using System;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using Laboratorio4.ContentContext;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank myBank = new Bank("DellBank", 39);


            Agencia myAgencia = new Agencia(myBank, 1);
            Agencia myAgencia2 = new Agencia(myBank, 2);
            Agencia myAgencia3 = new Agencia(myBank, 3);
            myBank.Agencias.Add(myAgencia);
            myBank.Agencias.Add(myAgencia2);
            myBank.Agencias.Add(myAgencia3);



            Client client1 = new Client("052.625.280-40", "Pedro Tomielo");
            Client client2 = new Client("868.569.441-87", "Rudi Tomielo");

            Account account1 = new Account(439, myBank, myAgencia, client1, 1000);
            Account account2 = new Account(439, myBank, myAgencia, client2, 20000);

            client1.ClientAccounts.Add(account1);
            myAgencia.Clients.Add(client1);

            client1.ClientAccounts.Add(account2);
            myAgencia.Clients.Add(client2);

            foreach (var agencia in myBank.Agencias)
            {
                System.Console.WriteLine("\n=== Agency ===");
                System.Console.WriteLine($"Bank name: {agencia.BankAgencia!.Name} - Id: {agencia.BankAgencia.Id} IdAgencia: {agencia.IdAgencia} ");
                foreach (var client in agencia.Clients)
                {
                    System.Console.WriteLine("\n=== Clients ===");
                    System.Console.WriteLine($"Client name: {client.ClientName} - Cpf: {client.Cpf} IdAgencia: {agencia.IdAgencia} - Bank {agencia.BankAgencia.Name} ");
                    foreach (var account in client.ClientAccounts)
                    {

                        System.Console.WriteLine($"Valor inicial{account.AccountInitialValue} ");
                    }

                }


            }
            System.Console.WriteLine(account1.AccountInitialValue);
            System.Console.WriteLine(account1.Saldo);
            account1.Sacar(100);
            System.Console.WriteLine(account1.Saldo);
            account1.Depositar(100);
            System.Console.WriteLine(account1.Saldo);




        }
    }
}