using System;

namespace AtmUI
{
    public class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public CurrentAccount CurrentAccount { get; set; }
        public SavingsAccount SavingsAccount { get; set; }
        public string Username { get; set; }
        public string PinCodeHash { get; set; }
    }
}