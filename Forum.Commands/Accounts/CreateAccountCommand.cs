﻿using System;
using ENode.Commanding;

namespace Forum.Commands.Accounts
{
    [Serializable]
    public class CreateAccountCommand : ProcessCommand<string>, ICreatingAggregateCommand
    {
        public string Name { get; private set; }
        public string Password { get; private set; }

        public CreateAccountCommand(string processId, string name, string password)
            : base(processId)
        {
            Name = name;
            Password = password;
        }
    }
}
