﻿using System.Threading.Tasks;
using FluentResults;
using Kysect.BotFramework.Core.CommandInvoking;

namespace Quewer.BotClient.Commands.QueCommands
{
    public class QuePushCommand : IBotCommand
    {
        public Result CanExecute(CommandArgumentContainer args)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result<string>> ExecuteAsync(CommandArgumentContainer args)
        {
            throw new System.NotImplementedException();
        }

        public string CommandName { get; } = "que-push";
        public string Description { get; }
        public string[] Args { get; } = { "Que name" };
    }
}